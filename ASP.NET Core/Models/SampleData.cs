using ASP_NET_Core.Models;
using System;
using System.Collections.Generic;

namespace ASP_NET_Core.Models {
    static class SampleData {
        public static List<State> GetStates()
        {
            List<State> States = new List<State> {
            new State {
                ID = 1,
                Name = "Alabama"
            },
            new State {
                ID = 2,
                Name = "Alaska"
            },
            new State {
                ID = 3,
                Name = "Arizona"
            },
            new State {
                ID = 4,
                Name = "Arkansas"
            },
            new State {
                ID = 5,
                Name = "California"
            },
            new State {
                ID = 6,
                Name = "Colorado"
            },
            new State {
                ID = 7,
                Name = "Connecticut"
            },
            new State {
                ID = 8,
                Name = "Delaware"
            },
            new State {
                ID = 9,
                Name = "District of Columbia"
            },
            new State {
                ID = 10,
                Name = "Florida"
            },
            new State {
                ID = 11,
                Name = "Georgia"
            },
            new State {
                ID = 12,
                Name = "Hawaii"
            },
            new State {
                ID = 13,
                Name = "Idaho"
            },
            new State {
                ID = 14,
                Name = "Illinois"
            },
            new State {
                ID = 15,
                Name = "Indiana"
            },
            new State {
                ID = 16,
                Name = "Iowa"
            },
            new State {
                ID = 17,
                Name = "Kansas"
            },
            new State {
                ID = 18,
                Name = "Kentucky"
            },
            new State {
                ID = 19,
                Name = "Louisiana"
            },
            new State {
                ID = 20,
                Name = "Maine"
            },
            new State {
                ID = 21,
                Name = "Maryland"
            },
            new State {
                ID = 22,
                Name = "Massachusetts"
            },
            new State {
                ID = 23,
                Name = "Michigan"
            },
            new State {
                ID = 24,
                Name = "Minnesota"
            },
            new State {
                ID = 25,
                Name = "Mississippi"
            },
            new State {
                ID = 26,
                Name = "Missouri"
            },
            new State {
                ID = 27,
                Name = "Montana"
            },
            new State {
                ID = 28,
                Name = "Nebraska"
            },
            new State {
                ID = 29,
                Name = "Nevada"
            },
            new State {
                ID = 30,
                Name = "New Hampshire"
            },
            new State {
                ID = 31,
                Name = "New Jersey"
            },
            new State {
                ID = 32,
                Name = "New Mexico"
            },
            new State {
                ID = 33,
                Name = "New York"
            },
            new State {
                ID = 34,
                Name = "North Carolina"
            },
            new State {
                ID = 35,
                Name = "Ohio"
            },
            new State {
                ID = 36,
                Name = "Oklahoma"
            },
            new State {
                ID = 37,
                Name = "Oregon"
            },
            new State {
                ID = 38,
                Name = "Pennsylvania"
            },
            new State {
                ID = 39,
                Name = "Rhode Island"
            },
            new State {
                ID = 40,
                Name = "South Carolina"
            },
            new State {
                ID = 41,
                Name = "South Dakota"
            },
            new State {
                ID = 42,
                Name = "Tennessee"
            },
            new State {
                ID = 43,
                Name = "Texas"
            },
            new State {
                ID = 44,
                Name = "Utah"
            },
            new State {
                ID = 45,
                Name = "Vermont"
            },
            new State {
                ID = 46,
                Name = "Virginia"
            },
            new State {
                ID = 47,
                Name = "Washington"
            },
            new State {
                ID = 48,
                Name = "West Virginia"
            },
            new State {
                ID = 49,
                Name = "Wisconsin"
            },
            new State {
                ID = 50,
                Name = "Wyoming"
            },
            new State {
                ID = 51,
                Name = "North Dakota"
            }
        };
            return States;
        }
        public static List<Employee> GetEmployees()
        {
            return new List<Employee> {
                    new Employee {
                        ID = 1,
                        FirstName = "John",
                        LastName = "Heart",
                        Phone = "(213) 555-9392",
                        Prefix = "Mr.",
                        Position = "CEO",
                        BirthDate = DateTime.Parse("1964/03/16"),
                        HireDate = DateTime.Parse("1995/01/15"),
                        Notes = "John has been in the Audio/Video industry since 1990. He has led DevAv as its CEO since 2003.\r\n\r\nWhen not working hard as the CEO, John loves to golf and bowl. He once bowled a perfect game of 300.",
                        Email = "jheart@dx-email.com",
                        Address = "351 S Hill St.",
                        City = "Los Angeles",
         AddressRequired = false,
                        State = "California",
                        StateID = 5,

                    },
                    new Employee {
                        ID = 2,
                        FirstName = "Olivia",
                        LastName = "Peyton",
                        Phone = "(310) 555-2728",
                        Prefix = "Mrs.",
                        Position = "Sales Assistant",
                        BirthDate = DateTime.Parse("1981/06/03"),
                        HireDate = DateTime.Parse("2012/05/14"),
                        Notes = "Olivia loves to sell. She has been selling DevAV products since 2012. \r\n\r\nOlivia was homecoming queen in high school. She is expecting her first child in 6 months. Good Luck Olivia.",
                        Email = "oliviap@dx-email.com",
                        Address = "807 W Paseo Del Mar",
                        City = "Los Angeles",
            AddressRequired = true,
                        State = "California",
                        StateID = 5,

                    },
                    new Employee {
                        ID = 3,
                        FirstName = "Robert",
                        LastName = "Reagan",
                        Phone = "(818) 555-2387",
                        Prefix = "Mr.",
                        Position = "CMO",
                        BirthDate = DateTime.Parse("1974/09/07"),
                        HireDate = DateTime.Parse("2002/11/08"),
                        Notes = "Robert was recently voted the CMO of the year by CMO Magazine. He is a proud member of the DevAV Management Team.\r\n\r\nRobert is a championship BBQ chef, so when you get the chance ask him for his secret recipe.",
                        Address = "4 Westmoreland Pl.",
                        City = "Bentonville",
              AddressRequired = true,
                        Email = "robertr@dx-email.com",
                        State = "Arkansas",
                        StateID = 4,

                    },
                    new Employee {
                        ID = 4,
                        FirstName = "Greta",
                        LastName = "Sims",
                        Phone = "(818) 555-6546",
                        Prefix = "Ms.",
                        Position = "HR Manager",
                        BirthDate = DateTime.Parse("1977/11/22"),
                        HireDate = DateTime.Parse("1998/04/23"),
                        Notes = "Greta has been DevAV's HR Manager since 2003. She joined DevAV from Sonee Corp.\r\n\r\nGreta is currently training for the NYC marathon. Her best marathon time is 4 hours. Go Greta.",
                        Email = "gretas@dx-email.com",
                        Address = "1700 S Grandview Dr.",
                        City = "Atlanta",
                        AddressRequired = true,
                        State = "Georgia",
                        StateID = 11,

                    },
                    new Employee {
                        ID = 5,
                        FirstName = "Brett",
                        LastName = "Wade",
                        Phone = "(626) 555-0358",
                        Prefix = "Mr.",
                        Position = "IT Manager",
                        BirthDate = DateTime.Parse("1968/12/01"),
                        HireDate = DateTime.Parse("2009/03/06"),
                        Notes = "Brett came to DevAv from Microsoft and has led our IT department since 2012.\r\n\r\nWhen he is not working hard for DevAV, he coaches Little League (he was a high school pitcher).",
                        Email = "brettw@dx-email.com",
                        Address = "1120 Old Mill Rd.",
                        City = "Boise",

                        State = "Idaho",
                        StateID = 13,
              AddressRequired = true
                    },
                    new Employee {
                        ID = 6,
                        FirstName = "Sandra",
                        LastName = "Johnson",
                        Phone = "(562) 555-2082",
                        Prefix = "Mrs.",
                        Position = "Controller",
                        BirthDate = DateTime.Parse("1974/11/15"),
                        HireDate = DateTime.Parse("2005/05/11"),
                        Notes = "Sandra is a CPA and has been our controller since 2008. She loves to interact with staff so if you've not met her, be certain to say hi.\r\n\r\nSandra has 2 daughters both of whom are accomplished gymnasts.",
                        Email = "sandraj@dx-email.com",
                        Address = "4600 N Virginia Rd.",
                        City = "Beaver",
               AddressRequired = false,
                        State = "Utah",
                        StateID = 44,

                    },
                    new Employee {
                        ID = 7,
                        FirstName = "Kevin",
                        LastName = "Carter",
                        Phone = "(213) 555-2840",
                        Prefix = "Mr.",
                        Position = "Shipping Manager",
                        BirthDate = DateTime.Parse("1978/01/09"),
                        HireDate = DateTime.Parse("2009/08/11"),
                        Notes = "Kevin is our hard-working shipping manager and has been helping that department work like clockwork for 18 months.\r\n\r\nWhen not in the office, he is usually on the basketball court playing pick-up games.",
                        Email = "kevinc@dx-email.com",
                        Address = "424 N Main St.",
                        City = "San Diego",
               AddressRequired = true,
                        State = "California",
                        StateID = 5,

                    },
                    new Employee {
                        ID = 8,
                        FirstName = "Cynthia",
                        LastName = "Stanwick",
                        Phone = "(818) 555-6655",
                        Prefix = "Ms.",
                        Position = "HR Assistant",
                        BirthDate = DateTime.Parse("1985/06/05"),
                        HireDate = DateTime.Parse("2008/03/24"),
                        Notes = "Cindy joined us in 2008 and has been in the HR department for 2 years. \r\n\r\nShe was recently awarded employee of the month. Way to go Cindy!",
                        Email = "cindys@dx-email.com",
                        Address = "2211 Bonita Dr.",
                        City = "Little Rock",
              AddressRequired = false,
                        State = "Arkansas",
                        StateID = 4,

                    },
                    new Employee {
                        ID = 9,
                        FirstName = "Kent",
                        LastName = "Samuelson",
                        Phone = "(562) 555-9282",
                        Prefix = "Dr.",
                        Position = "Ombudsman",
                        BirthDate = DateTime.Parse("1972/09/11"),
                        HireDate = DateTime.Parse("2009/04/22"),
                        Notes = "As our ombudsman, Kent is on the front-lines solving customer problems and helping our partners address issues out in the field.    He is a classically trained musician and is a member of the Chamber Orchestra.",
                        Email = "kents@dx-email.com",
                        Address = "12100 Mora Dr",
                        City = "St. Louis",
                 AddressRequired = true,
                        State = "Missouri",
                        StateID = 26,

                    },
                    new Employee {
                        ID = 10,
                        FirstName = "Taylor",
                        LastName = "Riley",
                        Phone = "(310) 555-7276",
                        Prefix = "Mr.",
                        Position = "Network Admin",
                        BirthDate = DateTime.Parse("1982/08/14"),
                        HireDate = DateTime.Parse("2012/04/14"),
                        Notes = "If you are like the rest of us at DevAV, then you've probably reached out for help from Taylor. He does a great job as a member of our IT department.",
                        Email = "taylorr@dx-email.com",
                        Address = "7776 Torreyson Dr",
                        City = "San Jose",

                        State = "California",
                        StateID = 5,

                    },
                    new Employee {
                        ID = 11,
                        FirstName = "Sam",
                        LastName = "Hill",
                        Phone = "(800) 555-2797",
                        Prefix = "Mr.",
                        Position = "Sales Assistant",
                        BirthDate = DateTime.Parse("1984/02/17"),
                        HireDate = DateTime.Parse("2012/02/01"),
                        Notes = "Sammy is proud to be a member of the DevAV team. He joined the team in 2012 and has been in the sales department from the beginning.\r\n\r\nHe has just picked up golf so you can find him on the links every weekend.",
                        Email = "sammyh@dx-email.com",
                        Address = "645 Prospect Crescent",
                        City = "Warner Robbins",
                       AddressRequired = false,
                        State = "Georgia",
                        StateID = 11,

                    },
                    new Employee {
                        ID = 12,
                        FirstName = "Kelly",
                        LastName = "Rodriguez",
                        Phone = "(800) 595-3232",
                        Prefix = "Ms.",
                        Position = "Support Assistant",
                        BirthDate = DateTime.Parse("1988/05/11"),
                        HireDate = DateTime.Parse("2012/10/13"),
                        Notes = "Kelly loves people and that's why she joined DevAV's support department. One of the funniest people in the company, she does stand-up on the weekends at the Laugh Factory.",
                        Email = "kellyr@dx-email.com",
                        Address = "1601 W Mountain St.",
                        City = "Compton",
                   AddressRequired = true,
                        State = "California",
                        StateID = 5,

                    },
                    new Employee {
                        ID = 13,
                        FirstName = "Natalie",
                        LastName = "Maguirre",
                        Phone = "(612) 304-6073",
                        Prefix = "Mrs.",
                        Position = "Trainer",
                        BirthDate = DateTime.Parse("1977/10/07"),
                        HireDate = DateTime.Parse("2008/06/19"),
                        Notes = "Natalie travels the US and teaches our partners how to explain the benefits of our products to customers.\r\n\r\nShe is a proud wife and mom and volunteers her time at the elementary school.",
                        Email = "nataliem@dx-email.com",
                        Address = "6400 E Bixby Hill Rd",
                        City = "Las Vegas",
                        AddressRequired = false,
                        State = "Nevada",
                        StateID = 29

                    },
                    new Employee {
                        ID = 14,
                        FirstName = "Walter",
                        LastName = "Hobbs",
                        Phone = "(800) 955-2292",
                        Prefix = "Mr.",
                        Position = "Programmer",
                        BirthDate = DateTime.Parse("1984/12/24"),
                        HireDate = DateTime.Parse("2011/02/17"),
                        Notes = "Walter has been developing apps and websites for DevAV since 2011. His passion is software and if you ever walk by his desk, you'll know why.\r\n\r\nWally once worked 72 hours straight - writing code and fixing bugs.",
                        Email = "walterh@dx-email.com",
                        Address = "10385 Shadow Oak Dr",
                        City = "Eagle",

                        State = "Idaho",
                        StateID = 13,
                        AddressRequired = true
                    }
                };
        }
    }
}
