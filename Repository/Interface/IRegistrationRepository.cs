using AdmissionProcess.Entity;

namespace AdmissionProcess.Repository.Interface
{
	public interface IRegistrationRepository
	{
		IEnumerable<Registration> GetAllRegistrations();
		Registration GetRegistrationById(int Admin_ID);
		int AddRegistration(Registration registration);
		int UpdateRegistration(Registration registration);
		int DeleteRegistration(int Admin_ID);
	}
}
