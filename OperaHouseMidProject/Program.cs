using OperaHouseMidProject.DataAccess;
using OperaHouseMidProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaHouseMidProject
{
    public class Program
    {
        //Method to insert values into DB At first time
        //We run them one time!!!
        public static async Task InsertUsersToDb()
        {
            using (var dbContext = new BlogDBContext())
            {
                //Insert users to Users table
                //Guest
                var newUser1 = new Fluent_users { UserId = "212733786", UserName = "Liraz Sionov", UserType = "guest" };
                //Director                
                var newUser2 = new Fluent_users { UserId = "011023066", UserName = "Gabi Sionov", UserType = "director" };                 
                dbContext.Add(newUser1);
                dbContext.Add(newUser2);
               await Task.Run(()=> dbContext.SaveChanges());
            }
        }

        public static async Task InsertArtistToDb()
        {
            //Insert artists to Artist table
            using (var dbContext = new BlogDBContext())
            {
                var artist1 = new Fluent_artists {ArtistId="212733786", FirstName = "Liraz", LastName = "Sionov", BirthDate ="19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0545259485", Gender = "f" };
                var artist2 = new Fluent_artists {ArtistId= "156534526", FirstName = "Robert", LastName = "Noach", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0567876676", Gender = "m" };
                var artist3 = new Fluent_artists {ArtistId= "098767543", FirstName = "Shoki", LastName = "Cohen", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0545633542", Gender = "m" };
                var artist4 = new Fluent_artists {ArtistId= "546545323", FirstName = "Noel", LastName = "Jo", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0567654343", Gender = "m" };
                var artist5 = new Fluent_artists {ArtistId= "097865454", FirstName = "Goni", LastName = "Lev", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0508765432", Gender = "m" };
                var artist6 = new Fluent_artists {ArtistId= "898767545", FirstName = "Gonatan", LastName = "Polard", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0525434567", Gender = "m" };
                var artist7 = new Fluent_artists {ArtistId= "094563452", FirstName = "Jakob", LastName = "Yampolsky", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0567654567", Gender = "m" };
                var artist8 = new Fluent_artists {ArtistId= "154352674", FirstName = "Losi", LastName = "Iyov", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0598765432", Gender = "m" };
                var artist9 = new Fluent_artists {ArtistId= "253546536", FirstName = "Eli", LastName = "Klain", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0509878909", Gender = "m" };
                var artist10 =new Fluent_artists {ArtistId= "112876543", FirstName = "Tami", LastName = "Peder", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0513243425", Gender = "m" };
                var artist11 =new Fluent_artists {ArtistId= "223465432", FirstName = "Lotem", LastName = "Lonasy", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0576545656", Gender = "m" };
                var artist12 =new Fluent_artists {ArtistId= "334534256", FirstName = "Nachum", LastName = "Pitarovsky", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0256514534", Gender = "m" };
                var artist14 =new Fluent_artists {ArtistId= "109874837", FirstName = "Peter", LastName = "Sionovsky", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "09989878", Gender = "m" };
                var artist18 =new Fluent_artists {ArtistId= "109837872", FirstName = "Witman", LastName = "Vitaminsy", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0987654567", Gender = "m" };
                var artist19 =new Fluent_artists {ArtistId= "109827837", FirstName = "Dochem", LastName = "Catz", BirthDate ="19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0545009485", Gender = "m" };
                var artist20 =new Fluent_artists {ArtistId= "100837829", FirstName = "Albert", LastName = "Shopen", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0523259485", Gender = "m" };
                dbContext.Add(artist1);
                dbContext.Add(artist2);
                dbContext.Add(artist3);
                dbContext.Add(artist4);
                dbContext.Add(artist5);
                dbContext.Add(artist6);
                dbContext.Add(artist7);
                dbContext.Add(artist8);
                dbContext.Add(artist9);
                dbContext.Add(artist10);
                dbContext.Add(artist11);
                dbContext.Add(artist12);
                dbContext.Add(artist14);
                dbContext.Add(artist18);
                dbContext.Add(artist19);
                dbContext.Add(artist20);
                await Task.Run(() =>dbContext.SaveChanges());
            }
        }
        public static async Task InsertInstancesToDb()
        {
            using (var dbContext = new BlogDBContext())
            {
                var Instance1 = new Fluent_InstanceType {InstanceID="1", Name = "הסימפוניה ", Composer = "ואן בטהובן", Writer = "אנדרו מקמהון", DateWriting = "10/01/2002" };
                var Instance2 = new Fluent_InstanceType {InstanceID="2", Name = "ברה מינור", Composer = "יוהאן סבס", Writer = "אנדרו מקמהון", DateWriting = "10/01/2002" };
                var Instance3 = new Fluent_InstanceType {InstanceID="3", Name = "דנובה הכחולה", Composer = "ואן בטהובן", Writer = "אנדרו מקמהון", DateWriting = "10/01/2002" };
                var Instance4 = new Fluent_InstanceType {InstanceID="4", Name = "מחול החרבות", Composer = "פרדריק שופן", Writer = "אנדרו מקמהון", DateWriting = "10/01/2002" };
                var Instance5 = new Fluent_InstanceType {InstanceID="5", Name = "ליזה לודוויג", Composer = "אמדאוס מוצרט", Writer = "אנדרו מקמהון", DateWriting = "10/01/2002" };
                dbContext.Add(Instance1);
                dbContext.Add(Instance2);
                dbContext.Add(Instance3);
                dbContext.Add(Instance4);
                dbContext.Add(Instance5);
               await Task.Run(()=>dbContext.SaveChanges());
            }
        }
        public static async Task InsertGuestToDb()
        {
            using (var dbContext = new BlogDBContext())
            {
                var guest1 = new Fluent_guests {GuestId="212733786",GuestName="Liraz sionov",ConcertName="מחול החרבות",DateConcert="01,12,2021",Hour="21:00",HallName="תמר",PhoneNumber="035567654" };
                dbContext.Add(guest1);
                await Task.Run(()=> dbContext.SaveChanges());
            }
             
        }
        public static async Task InsertHallsToDb()
        {
            using (var dbContext = new BlogDBContext())
            {
                var Hall1 = new Fluent_halls {HallId="1", HallName = "אביב", SeatsNum = "500" };
                var Hall2 = new Fluent_halls {HallId="2", HallName = "נחמה", SeatsNum = "300" };
                var Hall3 = new Fluent_halls {HallId="3", HallName = "גייסון", SeatsNum = "140" };
                var Hall4 = new Fluent_halls {HallId="4", HallName = "שלום", SeatsNum = "700" };
                var Hall5 = new Fluent_halls {HallId="5", HallName = "צליל", SeatsNum = "350" };
                var Hall6 = new Fluent_halls {HallId="6", HallName = "תמר", SeatsNum = "250" };
                var Hall7 = new Fluent_halls {HallId="7", HallName = "תמר", SeatsNum = "250" };
                var Hall8 = new Fluent_halls {HallId="8", HallName = "זית", SeatsNum = "250" };
                var Hall9 = new Fluent_halls {HallId="9", HallName = "תאנה", SeatsNum = "250" };
                var Hall10 =new Fluent_halls {HallId="10", HallName = "יאנה", SeatsNum = "250" };
                var Hall11 =new Fluent_halls {HallId="11", HallName = "סהר", SeatsNum = "250" };
                var Hall12 =new Fluent_halls {HallId="12", HallName = "רימון", SeatsNum = "250" };
                var Hall13 =new Fluent_halls {HallId="13", HallName = "סקסופון", SeatsNum = "250" };
                var Hall14 =new Fluent_halls {HallId="14", HallName = "צלו", SeatsNum =   "230" };
                var Hall15 =new Fluent_halls {HallId="15", HallName = "גיטר", SeatsNum =  "230" };
                var Hall16 =new Fluent_halls {HallId="16", HallName = "פיאנו", SeatsNum = "230" };
                var Hall17 =new Fluent_halls {HallId="17", HallName = "יוכבד", SeatsNum = "230" };
                var Hall18 =new Fluent_halls {HallId="18", HallName = "רקיע", SeatsNum =  "230" };
                var Hall19 =new Fluent_halls {HallId="19", HallName = "שופאן", SeatsNum = "230" };
               var Hall20 = new Fluent_halls {HallId="20", HallName = "רודוס", SeatsNum = "230" };
                dbContext.Add(Hall1);
                dbContext.Add(Hall2);
                dbContext.Add(Hall3);
                dbContext.Add(Hall4);
                dbContext.Add(Hall5);
                dbContext.Add(Hall6);
                dbContext.Add(Hall7);
                dbContext.Add(Hall8);
                dbContext.Add(Hall9);
                dbContext.Add(Hall10);
                dbContext.Add(Hall11);
                dbContext.Add(Hall12);
                dbContext.Add(Hall13);
                dbContext.Add(Hall14);
                dbContext.Add(Hall15);
                dbContext.Add(Hall16);
                dbContext.Add(Hall17);
                dbContext.Add(Hall18);
                dbContext.Add(Hall19);
                dbContext.Add(Hall20);

               await Task.Run(()=> dbContext.SaveChanges());
            }
        }
        public static async Task InsertConcertsToDb()
        {
            using (var dbContext = new BlogDBContext())
            {
                var concert1 = new Fluent_concerts { ConcertId = "1", InstanceName = "הסימפוניה ", ConductorName = "פיליפ הרווחה", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "תמר",HallNum="7", Cost = "150" };
                var concert2 = new Fluent_concerts { ConcertId = "2", InstanceName = "הסימפוניה ", ConductorName = "פיליפ הרווחה", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "אביב", HallNum = "1", Cost = "150" };
                var concert3 = new Fluent_concerts { ConcertId = "3", InstanceName = "טוקטה ופוגה", ConductorName = "ג'יזל בן-דור", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "נחמה", HallNum = "2", Cost = "150" };
                var concert4 = new Fluent_concerts { ConcertId = "4", InstanceName = "טוקטה ופוגה", ConductorName = "ג'יזל בן-דור", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "שלום", HallNum = "4", Cost = "150" };
                var concert5 = new Fluent_concerts { ConcertId = "5", InstanceName = "הדנובה הכחולה", ConductorName = "יונגר-הופמן", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "אביב", HallNum = "1", Cost = "150" };
                var concert6 = new Fluent_concerts { ConcertId = "6", InstanceName = "הדנובה הכחולה", ConductorName = "יונגר-הופמן", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "נחמה", HallNum = "2", Cost = "150" };
                var concert7 = new Fluent_concerts { ConcertId = "7", InstanceName = "מחול החרבות", ConductorName = "קמי קולצ'ינסקי", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "תמר", HallNum = "7", Cost = "150" };
                var concert8 = new Fluent_concerts { ConcertId = "8", InstanceName = "מחול החרבות", ConductorName = "קמ קולצ'ינסקי", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "תמר", HallNum = "7", Cost = "150" };
                var concert9 = new Fluent_concerts { ConcertId = "9", InstanceName = "מחול החרבות", ConductorName = "קמי קולצ'ינסקי", Duration = " 1.30", Date = "01/01/2022", Hour = "21:00", HallName = "תמר", HallNum = "7", Cost = "150" };
                var concert10 = new Fluent_concerts { ConcertId = "10", InstanceName = "מחול החרבות", ConductorName = "קמי קולצ'ינסקי", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "תמר", HallNum = "7", Cost = "150" };
                var concert11 = new Fluent_concerts { ConcertId = "11", InstanceName = "הדנובה הכחולה", ConductorName = "יונגר-הופמן", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "אביב", HallNum = "1", Cost = "150" };
                var concert12 = new Fluent_concerts { ConcertId = "12", InstanceName = "הדנובה הכחולה", ConductorName = "יונגר-הופמן", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "תמר", HallNum = "7", Cost = "150" };
                var concert13 = new Fluent_concerts { ConcertId = "13", InstanceName = "טוקטה מינור", ConductorName = "ג'יזל בן-דור", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "שלום", HallNum = "4", Cost = "150" };
                var concert14 = new Fluent_concerts { ConcertId = "14", InstanceName = "טוקטה מינור", ConductorName = "ג'יזל בן-דור", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "שלום", HallNum = "4", Cost = "150" };
                var concert15 = new Fluent_concerts { ConcertId = "15", InstanceName = "הסימפוניה ", ConductorName = "פיליפ הרווחה", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "שלום", HallNum = "4", Cost = "150" };
                var concert16 = new Fluent_concerts { ConcertId = "16", InstanceName = "הסימפוניה ", ConductorName = "פיליפ הרווחה", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "שלום", HallNum = "4", Cost = "150" };
                var concert17 = new Fluent_concerts { ConcertId = "17", InstanceName = "לאליזה לודווג", ConductorName = "קונרד יונגהנל", Duration = "1.30", Date = "01/01/2022", Hour = "21:00", HallName = "שלום", HallNum = "4", Cost = "150" };
                var concert18 = new Fluent_concerts { ConcertId = "18", InstanceName = "לאליזה לודויג", ConductorName = "קונרד יונגהנל", Duration = "1.30", Date = "01/04/2022", Hour = "21:00", HallName = "אביב", HallNum = "1", Cost = "150" };
                var concert19 = new Fluent_concerts { ConcertId = "19", InstanceName = "לאליזה לודויג", ConductorName = "קונרד יונגהנל", Duration = "1.30", Date = "01/03/2022", Hour = "21:00", HallName = "תמר", HallNum = "7", Cost = "150" };
                var concert20 = new Fluent_concerts { ConcertId = "20", InstanceName = "לאליזה לודויג", ConductorName = "קונרד יונגהנל", Duration = "1.30", Date = "01/02/2022", Hour = "21:00", HallName = "תמר", HallNum = "7", Cost = "150" };
                dbContext.Add(concert1);
                dbContext.Add(concert2);
                dbContext.Add(concert3);
                dbContext.Add(concert4);
                dbContext.Add(concert5);
                dbContext.Add(concert6);
                dbContext.Add(concert7);
                dbContext.Add(concert8);
                dbContext.Add(concert9);
                dbContext.Add(concert10);
                dbContext.Add(concert11);
                dbContext.Add(concert12);
                dbContext.Add(concert13);
                dbContext.Add(concert14);
                dbContext.Add(concert15);
                dbContext.Add(concert16);
                dbContext.Add(concert17);
                dbContext.Add(concert18);
                dbContext.Add(concert19);
                dbContext.Add(concert20);
                await Task.Run(() => dbContext.SaveChanges());
            }
        }

        public static async Task InsertConductorsToDb()
        {
            using (var dbContext = new BlogDBContext())
            {
                var conductor1 = new Fluent_conductors { ArtistId= "109827837", FirstName = "Dochem", LastName = "Catz", BirthDate ="19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0545009485", Gender = "m", SpecializationType = "Classic" };
                var conductor2 = new Fluent_conductors {
                    ArtistId = "100837829",
                    FirstName = "Albert",
                    LastName = "Shopen",
                    BirthDate = "19/06/1966",
                    City = "TV",
                    Address = "Moshe Sharet 37",
                    EmailAddress = "liza9470@gmail.com",
                    PhoneNumber = "0523259485",
                    Gender = " m",SpecializationType = "jazz" };

                dbContext.Add(conductor1);
                dbContext.Add(conductor2);
                await Task.Run(()=> dbContext.SaveChanges());
            }
        }
        public static async Task InsertPlayersToDb()
        {
            using (var dbContext = new BlogDBContext())
            {
                var Player1 = new Fluent_players {MusicalInstrument= "Cello", ArtistId = "156534526", FirstName = "Robert", LastName = "Noach", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0567876676", Gender = "m" };
                var Player2 = new Fluent_players {MusicalInstrument= "Sax", ArtistId = "098767543", FirstName = "Shoki", LastName = "Cohen", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0545633542", Gender = "m" };
                var Player4 = new Fluent_players {MusicalInstrument= "Sax", ArtistId = "546545323", FirstName = "Noel", LastName = "Jo", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0567654343", Gender = "m" };
                var Player5 = new Fluent_players {MusicalInstrument="Callo", ArtistId = "097865454", FirstName = "Goni", LastName = "Lev", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0508765432", Gender = "m" };
                var Player6 = new Fluent_players {MusicalInstrument= "Afghani guitar", ArtistId = "898767545", FirstName = "Gonatan", LastName = "Polard", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0525434567", Gender = "m" };
                var Player7 = new Fluent_players {MusicalInstrument= "trumpet", ArtistId = "094563452", FirstName = "Jakob", LastName = "Yampolsky", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0567654567", Gender = "m" };
                var Player8 = new Fluent_players {MusicalInstrument= "Accordion", ArtistId = "154352674", FirstName = "Losi", LastName = "Iyov", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0598765432", Gender = "m" };
                var Player9 = new Fluent_players {MusicalInstrument= "guitar", ArtistId = "253546536", FirstName = "Eli", LastName = "Klain", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0509878909", Gender = "m" };
                var Player10 = new Fluent_players{ MusicalInstrument = "violin", ArtistId = "112876543", FirstName = "Tami", LastName = "Peder", BirthDate = "19/06/1966", City = "TV", Address = "Moshe Sharet 37", EmailAddress = "liza9470@gmail.com", PhoneNumber = "0513243425", Gender = "m" };

                dbContext.Add(Player1);
                dbContext.Add(Player2);
                dbContext.Add(Player4);
                dbContext.Add(Player5);
                dbContext.Add(Player6);
                dbContext.Add(Player7);
                dbContext.Add(Player8);
                dbContext.Add(Player9);
                dbContext.Add(Player10);
                
               await Task.Run(()=> dbContext.SaveChanges());
            }
        }

        [STAThread]
        public static async Task Main(string[] args)
        {
            //Run it only one time!!!!!!!!!!!!!!!
            //In order ro insert value to db
            //Than put it in comment!!!!!!!!!!
            //await Task.Run(()=>InsertUsersToDb());
            //await Task.Run(()=>InsertArtistToDb());
            //await Task.Run(()=>InsertInstancesToDb());
            //await Task.Run(()=> InsertGuestToDb());
            //await Task.Run(() => InsertHallsToDb());
            // await Task.Run(() => InsertConcertsToDb());
            //await Task.Run(() => InsertConductorsToDb());
            //await Task.Run(()=> InsertPlayersToDb());



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await Task.Run(() => Application.Run(new HomePage()));
        }

}
    
}

