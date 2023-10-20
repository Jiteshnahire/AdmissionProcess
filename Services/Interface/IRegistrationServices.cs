using AdmissionProcess.Entity;

namespace AdmissionProcess.Services.Interface
{
	public interface IRegistrationServices
	{
		IEnumerable<Registration> GetAllRegistrations();
		Registration GetRegistrationById(int Admin_ID);
		int AddRegistration(Registration registration);
		int UpdateRegistration(Registration registration);
		int DeleteRegistration(int Admin_ID);
	}
}
