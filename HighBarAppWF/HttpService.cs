using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HighBarAppWF
{
    public class HttpService
    {
        private static HttpClient _client = null;
        private static string baseURL = "http://192.168.10.103:3333/";
        public static HttpClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new HttpClient();
                }
                return _client;
            }
        }
        public HttpService()
        {
            //some operation
        }

        public static async Task<List<Clinic>> GetClinicsAsync()
        {
            List<Clinic> clinics = new List<Clinic>();
            //HttpResponseMessage response = await Client.GetAsync(path);
            //if (response.IsSuccessStatusCode)
            //{
            //    clinics = await response.Content.ReadAsAsync<List<Clinic>>();
            //}
            clinics.Add(new Clinic() { Code = "bent", Name = "Bentleigh" });
            clinics.Add(new Clinic() { Code = "chad", Name = "Chadstone" });
            clinics.Add(new Clinic() { Code = "moor", Name = "Mooroolbark" });
            clinics.Add(new Clinic() { Code = "stkd", Name = "StKilda" });
            clinics.Add(new Clinic() { Code = "clay", Name = "Clayton" });
            clinics.Add(new Clinic() { Code = "lily", Name = "Lilydale" });
            return clinics;
        }
        public static async Task<List<Doctor>> GetDoctorsByClinicAsync(string CodeSite, string date)
        {
            List<Doctor> doctors = new List<Doctor>();
            var url = baseURL + $"api/appointment?codeAction=appointmentsByDate&CodeSite={CodeSite}&date={date}";
            HttpResponseMessage response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                doctors = await response.Content.ReadAsAsync<List<Doctor>>();
            }
            return doctors;
        }
        //http://192.168.10.103:3333/api/appointment?codeAction=appointmentsByDate&codeSite=bent&date=17-05-2018
        public static async Task<List<Appointment>> GetAppointmentByDate(string CodeSite, string date,string doctor)
        {
            List<Appointment> appointments = new List<Appointment>();
            var url = baseURL + $"api/appointment?codeAction=appointmentsByDate&CodeSite={CodeSite}&date={date}&doctor={doctor}";
            HttpResponseMessage response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                appointments = await response.Content.ReadAsAsync<List<Appointment>>();
            }
            return appointments;
        }
    }
}
