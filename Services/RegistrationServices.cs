using AdmissionProcess.Entity;
using AdmissionProcess.Repository.Interface;
using AdmissionProcess.Services.Interface;
using Microsoft.Win32;

namespace AdmissionProcess.Services
{
	public class RegistrationServices : IRegistrationServices
	{
		private readonly IRegistrationRepository repository;
		public RegistrationServices(IRegistrationRepository repository)
		{
			this.repository = repository;
		}
		public int AddRegistration(Registration registration)
		{
			return repository.AddRegistration(registration);
		}

		public int DeleteRegistration(int Admin_ID)
		{
			return repository.DeleteRegistration(Admin_ID);
		}

		public IEnumerable<Registration> GetAllRegistrations()
		{
			return repository.GetAllRegistrations();
		}

		public Registration GetRegistrationById(int Admin_ID)
		{
			return repository.GetRegistrationById(Admin_ID);
		}

		public int UpdateRegistration(Registration registration)
		{
			return repository.UpdateRegistration(registration);
		}
	}
}
