using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareProject.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }      
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentStatus { get; set; }
        public string AppBookingChannelName { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }

    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<ClientReview> ClientReview { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }

    }

    public class ClientReview
    {
        public int Id { get; set; }       
        public int WaitTimeRating { get; set; }
        public int DoctorRating { get; set; }
        public string Review { get; set; }
        public string IsDoctorRecommended { get; set; }
        public string ReviewDate { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }

    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PracticingForm { get; set; }
        public string Specialization { get; set; }     

        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<ClientReview> ClientReview { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }


    }


    public class Hospital
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string FirstConsultationFee { get; set; }
        public string FollowUpConsultationFee { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }

        public virtual ICollection<Doctor> Doctor { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }

    }

    [Keyless]
    public class Ad_login
    {        
        public int Id { get; set; }
        public string Admin_id { get; set; }
        public string Ad_Password { get; set; }
    }
}



