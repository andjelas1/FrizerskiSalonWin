using FrizerskiSalonObjekti;
using FrizerskiSalonObjekti.FSObjekti;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace FrizerskiSalonAPI.FSPristupBazi
{
    public class PristupBazi : IPristupBazi
    {
        private readonly fzDbContext _baza;
        public PristupBazi(fzDbContext baza)
        {
            _baza = baza;

        }
        public void KreirajRadnika(Radnik radnik)
        {
            var param1 = new SqlParameter("@Param1", radnik.Ime_Prezime);
            _baza.Database.ExecuteSqlRaw($"insert into radnik select @Param1", param1);
        }

        public Radnik UcitajRadnika(int idRadnik)
        {
            var param1 = new SqlParameter("@Param1", idRadnik);
            var radnik = _baza.Database.SqlQueryRaw<Radnik>("select * from radnik where id_ranik = @Param1", param1).FirstOrDefault();

            return radnik;
        }

        public IEnumerable<Radnik> UcitajRadnike()
        {
            var lista = _baza.Database.SqlQueryRaw<Radnik>("select * from radnik").ToList();
            return lista;
        }
        public IEnumerable<RadnoVreme> UcitajRadnoVremeRadnika(Radnik radnik)
        {
            var param1 = new SqlParameter("@Param1", radnik.ID_Radnik);
            var raqdnovreme = _baza.Database.SqlQueryRaw<RadnoVreme>("select ID_RadnoVreme, Datum, Vreme_OD, Vreme_DO from radnovreme where id_radnik = @Param1", param1).ToList();

            return raqdnovreme;
        }

        public void KreirajRasporedZaRadnika(Radnik radnik, int mesec, int godina, bool prepodne)
        {

            DateOnly prviUIzabranomMesecu = new DateOnly(godina, mesec, 1);
            DateOnly sledeciDan = prviUIzabranomMesecu;
            
            DateOnly poslednjiUIzabranomMesecu = new DateOnly(godina, mesec+1, 1).AddDays(-1);

            var param01 = new SqlParameter("@Param01", radnik.ID_Radnik);
            var param02 = new SqlParameter("@Param02", prviUIzabranomMesecu);

            var postojeciZapisi = _baza.Database.SqlQueryRaw<RadnoVreme>($"select * from radnoVreme where id_radnik = @Param01 and datum = @Param02", param01, param02).ToList();
            if (postojeciZapisi.Count > 0)
                return;  // pretpostavka da je sa svakim prvim danom u mesecu, kreiran citav raspored za mesec.

            var vremeOD = prepodne ? new TimeOnly(7, 0, 0) : new TimeOnly(14, 0, 0);
            var vremeDO = prepodne ? new TimeOnly(14, 0, 0) : new TimeOnly(21, 0, 0);

            while (sledeciDan <= poslednjiUIzabranomMesecu)
            {
                if(sledeciDan.DayOfWeek == DayOfWeek.Sunday) { sledeciDan = sledeciDan.AddDays(1); } // preskacemo Nedelju, ne radi se
                
                //menjamo smenu sa pocetkom sledece nedelje
                if (sledeciDan != prviUIzabranomMesecu && sledeciDan.DayOfWeek == DayOfWeek.Monday) { 
                    prepodne = !prepodne;
                    vremeOD = prepodne ? new TimeOnly(7, 0, 0) : new TimeOnly(14, 0, 0);
                    vremeDO = prepodne ? new TimeOnly(14, 0, 0) : new TimeOnly(21, 0, 0);
                }

                var param1 = new SqlParameter("@Param1", radnik.ID_Radnik);
                var param2 = new SqlParameter("@Param2", sledeciDan);
                var param3 = new SqlParameter("@Param3", vremeOD);
                var param4 = new SqlParameter("@Param4", vremeDO);
                _baza.Database.ExecuteSqlRaw($"insert into radnovreme select @Param1, @Param2, @Param3, @Param4", param1, param2, param3, param4);

                var satnicaOD = vremeOD;
                while (satnicaOD < vremeDO)
                {
                    var param21 = new SqlParameter("@Param21", radnik.ID_Radnik);
                    var param22 = new SqlParameter("@Param22", sledeciDan);
                    var param23 = new SqlParameter("@Param23", satnicaOD);
                    _baza.Database.ExecuteSqlRaw($"insert into zakazivanje select @Param21, @Param22, @Param23, 1,null, null", param21, param22, param23);
                    satnicaOD = satnicaOD.AddMinutes(15);
                }

                sledeciDan = sledeciDan.AddDays(1);

            }
        }

        public IEnumerable<Usluga> UcitajSveUsluge()
        {
            var lista = _baza.Database.SqlQueryRaw<Usluga>("select * from usluga").ToList();
            return lista;
        }
        public void KreirajUslugu(Usluga usluga)
        {
            var param1 = new SqlParameter("@Param1", usluga.Naziv);
            var param2 = new SqlParameter("@Param2", usluga.Trajanje);
            var param3 = new SqlParameter("@Param3", usluga.Cena);
            _baza.Database.ExecuteSqlRaw($"insert into usluga select @Param1, @Param2, @Param3", param1, param2, param3);
        }

        public IEnumerable<Radnik> UcitajRadnikeZaUslugu(Usluga usluga)
        {
            var param1 = new SqlParameter("@Param1", usluga.ID_Usluga);
            var radnici = _baza.Database.SqlQueryRaw<Radnik>("select r.* from Radnik r inner join Tretman tr on tr.ID_radnik = r.ID_radnik where tr.ID_Usluga = @Param1", param1).ToList();
            return radnici;
        }

        public void SacuvajTretmane(List<Tretman> tretmani)
        {
            var param1 = new SqlParameter("@Param1", tretmani[0].Usluga.ID_Usluga);
            _baza.Database.ExecuteSqlRaw($"delete from tretman where id_usluga = @Param1", param1);

            foreach (var t in tretmani)
            {
                var param21 = new SqlParameter("@Param21", t.Usluga.ID_Usluga);
                var param22 = new SqlParameter("@Param22", t.Radnik.ID_Radnik);
                _baza.Database.ExecuteSqlRaw($"insert into tretman select @Param21, @Param22", param21, param22);
            }
        }

        public IEnumerable<Zakazivanje> PronadjiTermin(ZakazivanjeZahtev zahtev)
        {
            var datum_param = new SqlParameter("@datum", zahtev.Datum);

            var vreme_od = zahtev.Prepodne ? new TimeOnly(7,0,0) : new TimeOnly(14,0,0);
            var smena_od_param = new SqlParameter("@smena_od", vreme_od);

            // prvo da nadjemo ko sve nudi usluge
            var uslugaRadnici = new Hashtable(); 
            foreach(var u in zahtev.Usluge)
            {
                var id_Usluga_param = new SqlParameter("@ID_usluga", u.ID_Usluga);
                var radnici = _baza.Database.SqlQueryRaw<Radnik>("select distinct r.* " +
                    "from Radnik r " +
                    "inner join Tretman t on t.id_radnik = r.id_Radnik and t.id_usluga = @ID_usluga " +
                    "inner join RadnoVreme rv on rv.ID_Radnik = r.ID_Radnik and rv.Datum = @datum " +
                    "and rv.Vreme_Od = @smena_od", id_Usluga_param, datum_param, smena_od_param)
                    .ToList();
                if( radnici != null && radnici.Count > 0)
                    uslugaRadnici.Add(u, radnici);
            }

            var termini = new Hashtable();

            foreach (Usluga usl in uslugaRadnici.Keys)
            {
                foreach (Radnik rad in (List<Radnik>)uslugaRadnici[usl])
                {
                    var id_radnik_param = new SqlParameter("@id_radnik", rad.ID_Radnik);
                    //var rezultat = _baza.Database.SqlQueryRaw<object>("select Datum, Vreme_OD, Moze "+
                    //    "from Zakazivanje z "+
                    //    "where z.datum = @datum and z.id_radnik = @id_radnik and z.moze = 1 order by vreme_od", datum_param, id_radnik_param);
                    var slotovi = new List<Zakazivanje>();
                    using (var command = _baza.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = $"select Datum, Vreme_OD, Moze " +
                        "from Zakazivanje z " +
                        "where z.datum = @datum and z.id_radnik = @id_radnik and z.moze = 1 order by vreme_od";
                        command.Parameters.Add(id_radnik_param);
                        command.Parameters.Add(datum_param);
                        _baza.Database.OpenConnection();

                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var slot = new Zakazivanje();
                            slot.Datum = DateOnly.FromDateTime(reader.GetDateTime(0));
                            slot.Vreme_OD = TimeOnly.FromTimeSpan((TimeSpan)reader.GetValue(1));
                            slot.Moze = reader.GetBoolean(2);

                            slotovi.Add(slot);
                        }
                    }

                    var trenutniSlot = new Zakazivanje();
                    var sledeciSlot = new Zakazivanje();

                    var trajanjeUsluge = usl.Trajanje;
                    trenutniSlot = slotovi[0];
                    sledeciSlot = slotovi[1];
                    if (trenutniSlot.Vreme_OD == sledeciSlot.Vreme_OD.AddMinutes(-15))
                    {
                        trajanjeUsluge -= 15;
                    }

                }
            }
            return new List<Zakazivanje>();
        }
    }
}
