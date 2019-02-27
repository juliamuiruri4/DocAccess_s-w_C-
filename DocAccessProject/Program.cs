using System;
using static System.Console;

namespace DocAccessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessGranting();
            
            
            
            PhysicalIdentityAndAccess();
            ReadKey();
        }
        //method to deal with identification of the user.
        public static void BiometricIdentification()
        {

        }
        //method to deal with authorization of the user
        public static void AccessGranting()
        {
            string Name;
            int Code;
            WriteLine("Kindly enter your 3 names");
            Name =ReadLine();
            Name = Name.ToLower();
            switch(Name)
            {
                //a user by the name julia wambui muiruri is allowed to access the information inside
                case  "julia wambui muiruri":
                    Clear();
                    WriteLine("Welcome {0} \nKindly enter your code",Name);
                    Code = Convert.ToInt32(ReadLine());
                    if (Code == 4444)
                    {
                        WriteLine("Access granted");
                        WriteLine("\t\tWelcome to Document Management 2020");
                        WriteLine("Would you like to access the funds chamber?");
                        WriteLine("1.Yes\n2.No");
                    }
                    else
                        WriteLine("Access denied. SECURITY BREACH");
                    break;
                //a user by the name steven kariuki muiruri is allowed to access the information inside
                case "steven kariuki muiruri":
                    Clear();
                    WriteLine("Welcome {0} \nKindly enter your code", Name);
                    Code = Convert.ToInt16(ReadLine());
                    if (Code == 3333)
                    {
                        WriteLine("Access granted");
                        WriteLine("\t\tWelcome to Document Management 2020");
                        WriteLine("Would you like to access the funds chamber?");
                        WriteLine("1.Yes\n2.No");
                    }
                    else
                        WriteLine("Access denied. SECURITY BREACH");
                    break;
                default:
                    WriteLine("You are not authorized to access this information");
                    break;

            }

        }
        public static void PhysicalIdentityAndAccess()
        {
           
            int FundsAccess;//whether or not to access funds information
            string CountyChoice;
            

            FundsAccess = Convert.ToInt16(ReadLine());
            if (FundsAccess == 1)//choice is to not access the funds
            {
                Clear();
                WriteLine("Which county would you like to access?");
                CountyChoice = Convert.ToString(ReadLine());

                switch (CountyChoice)//the county of choice
                {
                    case "kiambu":
                        Clear();
                        WriteLine("Kiambu county is county number 22");
                        WriteLine("The governer is Mr.Ferdinand Waititu");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "murang'a":
                        Clear();
                        WriteLine("Murang'a county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th September 2018 by the deputy president for building a foot bridge: Ksh.1 040 000");
                        WriteLine("Funds already used for the construction: Ksh.900 000");
                        WriteLine("The balance in this county's account: Ksh.140 000");

                        break;
                    case "mombasa":
                        Clear();
                        WriteLine("Mombasa county is county number 1");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 11th October 2019 by the governer for building a road: Ksh.2 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.1 054 000");

                        break;
                    case "machakos":
                        Clear();
                        WriteLine("Machakos county is county number ");
                        WriteLine("The governer is Mr. Alfred Mutua");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kwale":
                        Clear();
                        WriteLine("Kwale county is county number ");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kilifi":
                        Clear();
                        WriteLine("Kilifi county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                        Clear();
                    case "tana river":
                        WriteLine("Tana River county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "lamu":
                        Clear();
                        WriteLine("Lamu county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "taita taveta":
                        Clear();
                        WriteLine("Taita Taveta county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "nyandarua":
                        Clear();
                        WriteLine("Nyandarua county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");
                        break;
                    case "nyeri":
                        Clear();
                        WriteLine("Nyeri county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kirinyaga":
                        Clear();
                        WriteLine("Kirinyaga county is county number");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                        
                    case "marsabit":
                        Clear();
                        WriteLine("Marsabit county is county number ");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "isiolo":
                        Clear();
                        WriteLine("Isiolo county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "meru":
                        Clear();
                        WriteLine("Meru county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "tharaka nithi":
                        Clear();
                        WriteLine("Tharaka- Nithi county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "embu":
                        Clear();
                        WriteLine("Embu county is county number1");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kitui":
                        Clear();
                        WriteLine("Kitui county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "makueni":
                        Clear();
                        WriteLine("Makueni county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "nairobi":
                        Clear();
                        WriteLine("Nairobi county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "turkana":
                        Clear();
                        WriteLine("Turkana county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "west pokot":
                        Clear();
                        WriteLine("West Pokot county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "samburu":
                        Clear();
                        WriteLine("Samburu county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "trans nzoia":
                        Clear();
                        WriteLine("Trans Nzoia county is county number");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "baringo":
                        Clear();
                        WriteLine("Baringo county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "uasin gishu":
                        Clear();
                        WriteLine("Uasin Gishu county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "elgeyo marakwet":
                        Clear();
                        WriteLine("Elgeyo-Marakwet county is county number");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "nandi":
                        Clear();
                        WriteLine("Nandi county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "laikipia":
                        Clear();
                        WriteLine("Laikipia county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "nakuru":
                        Clear();
                        WriteLine("Nakuru county is county number ");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "narok":
                        Clear();
                        WriteLine("Narok county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kajiado":
                        Clear();
                        WriteLine("Kajiado county is county number ");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kericho":
                        Clear();
                        WriteLine("Kericho county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "bomet":
                        Clear
                            ();
                        WriteLine("Bomet county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kakamega":
                        Clear();
                        WriteLine("Kakamega county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "vihiga":
                        Clear();
                        WriteLine("Vihiga county is county number ");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "bungoma":
                        Clear();
                        WriteLine("Bongoma county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "busia":
                        Clear();
                        WriteLine("Busia county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "siaya":
                        Clear();
                        WriteLine("Siaya county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kisumu":
                        Clear();
                        WriteLine("Kisumu county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "homa bay":
                        Clear();
                        WriteLine("Homa Bay county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "migori":
                        Clear();
                        WriteLine("Migori county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "kisii":
                        Clear();
                        WriteLine("Kisii county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "nyamira":
                        Clear();
                        WriteLine("Nyamira county is county number ");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "garissa":
                        Clear();
                        WriteLine("Garissa county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "wajir":
                        Clear();
                        WriteLine("Wajir county is county number");
                        WriteLine("The governer is ");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    case "mandera":
                        Clear();
                        WriteLine("Mandera county is county number ");
                        WriteLine("The governer is");
                        WriteLine("Funds allocated to this county on 12th December 2018 by the president for building the road: Ksh.1 000 000");
                        WriteLine("Funds already used for the construction: Ksh.946 000");
                        WriteLine("The balance in this county's account: Ksh.34 000");

                        break;
                    default:
                        WriteLine("Invalid input\nPlease type in the correct name of the county");
                        break;

                }
            }


            else if (FundsAccess == 2)//no need to access funds information
            {
                Clear();
                WriteLine("Which county would you like to access?");
                CountyChoice = Convert.ToString(ReadLine());
                switch (CountyChoice)
                {
                    case "kiambu":
                        Clear();
                        WriteLine("Kiambu county is county number 22");
                        WriteLine("The governer is Mr.Ferdinand Waititu");

                        break;
                    case "murang'a":
                        Clear();
                        WriteLine("Murang'a county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "mombasa":
                        Clear();
                        WriteLine("Mombasa county is county number 1");
                        WriteLine("The governer is ");

                        break;
                    case "machakos":
                        Clear();
                        WriteLine("Machakos county is county number ");
                        WriteLine("The governer is Mr. Alfred Mutua");

                        break;
                    case "kwale":
                        Clear();
                        WriteLine("Kwale county is county number ");
                        WriteLine("The governer is");

                        break;
                    case "kilifi":
                        Clear();
                        WriteLine("Kilifi county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "tana river":
                        Clear();
                        WriteLine("Tana River county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "lamu":
                        Clear();
                        WriteLine("Lamu county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "taita taveta":
                        Clear();
                        WriteLine("Taita Taveta county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "nyandarua":
                        Clear();
                        WriteLine("Nyandarua county is county number ");
                        WriteLine("The governer is ");
                        break;
                    case "nyeri":
                        Clear();
                        WriteLine("Nyeri county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "kirinyaga":
                        Clear();
                        WriteLine("Kirinyaga county is county number");
                        WriteLine("The governer is");

                        break;
                    case "marsabit":
                        Clear();
                        WriteLine("Marsabit county is county number ");
                        WriteLine("The governer is");

                        break;
                    case "isiolo":
                        Clear();
                        WriteLine("Isiolo county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "meru":
                        Clear();
                        WriteLine("Meru county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "tharaka nithi":
                        Clear();
                        WriteLine("Tharaka- Nithi county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "embu":
                        Clear();
                        WriteLine("Embu county is county number1");
                        WriteLine("The governer is ");

                        break;
                    case "kitui":
                        Clear();
                        WriteLine("Kitui county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "makueni":
                        Clear();
                        WriteLine("Makueni county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "nairobi":
                        Clear();
                        WriteLine("Nairobi county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "turkana":
                        Clear();
                        WriteLine("Turkana county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "west pokot":
                        Clear();
                        WriteLine("West Pokot county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "samburu":
                        Clear();
                        WriteLine("Samburu county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "trans nzoia":
                        Clear();
                        WriteLine("Trans Nzoia county is county number");
                        WriteLine("The governer is");

                        break;
                    case "baringo":
                        Clear();
                        WriteLine("Baringo county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "uasin gishu":
                        Clear();
                        WriteLine("Uasin Gishu county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "elgeyo marakwet":
                        Clear();
                        WriteLine("Elgeyo-Marakwet county is county number");
                        WriteLine("The governer is");

                        break;
                    case "nandi":
                        Clear();
                        WriteLine("Nandi county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "laikipia":
                        Clear();
                        WriteLine("Laikipia county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "nakuru":
                        Clear();
                        WriteLine("Nakuru county is county number ");
                        WriteLine("The governer is");

                        break;
                    case "narok":
                        Clear();
                        WriteLine("Narok county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "kajiado":
                        Clear();
                        WriteLine("Kajiado county is county number ");
                        WriteLine("The governer is");

                        break;
                    case "kericho":
                        Clear();
                        WriteLine("Kericho county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "bomet":
                        Clear();
                        WriteLine("Bomet county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "kakamega":
                        Clear();
                        WriteLine("Kakamega county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "vihiga":
                        Clear();
                        WriteLine("Vihiga county is county number ");
                        WriteLine("The governer is");

                        break;
                    case "bungoma":
                        Clear();
                        WriteLine("Bongoma county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "busia":
                        Clear();
                        WriteLine("Busia county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "siaya":
                        Clear();
                        WriteLine("Siaya county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "kisumu":
                        Clear();
                        WriteLine("Kisumu county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "homa bay":
                        Clear();
                        WriteLine("Homa Bay county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "migori":
                        Clear();
                        WriteLine("Migori county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "kisii":
                        Clear();
                        WriteLine("Kisii county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "nyamira":
                        Clear();
                        WriteLine("Nyamira county is county number ");
                        WriteLine("The governer is ");

                        break;
                    case "garissa":
                        Clear();
                        WriteLine("Garissa county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "wajir":
                        Clear();
                        WriteLine("Wajir county is county number");
                        WriteLine("The governer is ");

                        break;
                    case "mandera":
                        Clear();
                        WriteLine("Mandera county is county number ");
                        WriteLine("The governer is");

                        break;
                }

            }

            

        }

    }
}
