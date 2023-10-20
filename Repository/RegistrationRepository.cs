using AdmissionProcess.Entity;
using AdmissionProcess.Repository.Interface;
using Microsoft.Win32;

namespace AdmissionProcess.Repository
{
	public class RegistrationRepository : IRegistrationRepository
	{
		private readonly ApplicationDbContext context;
		public RegistrationRepository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public int AddRegistration(Registration registration)
		{
			int res = 0;
			context.Registrations.Add(registration);
			res = context.SaveChanges();
			return res;
		}

		public int DeleteRegistration(int Admin_ID)
		{
			int res = 0;
			var register = context.Registrations.Where(x => x.Admin_ID == Admin_ID).FirstOrDefault();
			if (register != null)
			{
			
				res = context.SaveChanges();
			}
			return res;
		}

		public IEnumerable<Registration> GetAllRegistrations()
		{
			return context.Registrations.ToList();
		}

		public Registration GetRegistrationById(int Admin_ID)
		{
			int res = 0;
			var register = context.Registrations.Where(x => x.Admin_ID == Admin_ID).FirstOrDefault();
			return register;
		}

		public int UpdateRegistration(Registration registration)
		{
			int res = 0;
			var reg = context.Registrations.Where(x => x.Admin_ID == registration.Admin_ID).FirstOrDefault();
			if (reg != null)
			{
				reg.Fullname = registration.Fullname;
				reg.Mobile = registration.Mobile;
				reg.Email = registration.Email;
				reg.Password = registration.Password;
				reg.Reg_Date = registration.Reg_Date;
				reg.Admin_status = registration.Admin_status;
				res = context.SaveChanges();
			}
			return res;
		}
	}
}
