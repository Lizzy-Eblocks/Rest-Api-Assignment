
/*
 * [2019] - [2021] Eblocks Software (Pty) Ltd, All Rights Reserved.
 * NOTICE: All information contained herein is, and remains the property of Eblocks
 * Software (Pty) Ltd.
 * and its suppliers (if any). The intellectual and technical concepts contained herein
 * are proprietary
 * to Eblocks Software (Pty) Ltd. and its suppliers (if any) and may be covered by South 
 * African, U.S.
 * and Foreign patents, patents in process, and are protected by trade secret and / or 
 * copyright law.
 * Dissemination of this information or reproduction of this material is forbidden unless
 * prior written
 * permission is obtained from Eblocks Software (Pty) Ltd.
*/
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using af.assessment.api.Data.Models;
using af.assessment.api.Enums;

namespace af.assessment.api.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class SeedData
    {
        /// <summary>
        /// 
        /// </summary>
        private static Guid locationId = Guid.Parse("acf3f16436404db2bc8ba3b4531e0b86");
        
        /// <summary>
        /// 
        /// </summary>
        private static Guid _memberId = Guid.Parse("2c6a1350-7fae-4b80-8c9f-c18c7f206028");
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Member SeedMember()
        {
            return new Member()
            {
                Id = _memberId,
                IdentificationNumber = 9103010087098,
                MobileNumber = 0879998765,
                Name = "Sarah",
                Password = "hashedPassword",
                Email = "email@address.com",
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        ///
        /// </returns>
        public static List<FamilyMember> SeedFamilyMembers()
        {
            var familyMemberList = new List<FamilyMember>()
            {
                new FamilyMember()
                {
                    Id = Guid.Parse("8c907bc1-8c37-4c71-95e3-c35519280062"),
                    FirstName = "Maddy",
                    LastName = "Mason",
                    IdentificationNumber = 98098854081,
                    Member = MemberType.Daughter,
                    VaccineStatus = true
                },
                new FamilyMember()
                {
                    Id = Guid.Parse("77d4f8cc-9797-4f25-9b99-69fde7aeb495"),
                    FirstName = "Brad",
                    LastName = "Mason",
                    IdentificationNumber = 98334854081,
                    Member = MemberType.Son,
                    VaccineStatus = false,
                }
            };
            
            return familyMemberList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Appointment> SeedAppointments()
        {
            var appointmentList = new List<Appointment>()
            {
                new Appointment()
                {
                    Id = Guid.Parse("f6e3d125-609a-4db0-a909-2e104170f108"),
                    AvailableDate = new DateTime(2021, 11, 01),
                    DateSelected = new DateTime(2021, 11,02),
                    MemberId = _memberId,
                    Status = AppointmentStatus.UpComing,
                }
            };
            return appointmentList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Location SeedLocation()
        {
            return
                new Location()
                {
                    Id = locationId,
                    City = "Johannesburg",
                    StreetName = "21st Street",
                    PostalCode = 1220
                };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        ///
        /// </returns>
        public static Vaccine SeedVaccine()
        {
            return new Vaccine()
            {
                Id = Guid.Parse("3608a3c3-8e5c-4af5-a38c-fb843344080b"),
                Dose = 0.12,
                Name = "Hepatitis A",
               // LocationId = Guid.Parse("1fd773ff-a86f-458e-8e80-b5ac9c4acf0e")
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        ///
        /// </returns>
        public static List<Vaccine> SeedVaccines()
        {
            var vaccineList = new List<Vaccine>()
            {
                new Vaccine()
                {
                    Id = Guid.Parse("fabda97c-eaff-41ca-ae32-0c0a099d2955"),
                    Dose = 0.07,
                    Name = "Haemophilus Influenzae type B",
                },
                new Vaccine()
                {
                    Id = Guid.Parse("8ce0c789-f7bd-4a9c-a491-45df5b386657"),
                    Dose = 0.12,
                    Name = " Rotavirus Gastroenteritis",
                },
                new Vaccine()
                {
                    Id = Guid.Parse("e36265ea-0e0d-4a9c-8275-9cac364e75a6"),
                    Dose = 0.8,
                    Name = " Tetanus ",
                   
                }
            };
            return vaccineList;
        }
    }
}