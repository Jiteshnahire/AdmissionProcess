using AdmissionProcess.Entity;

namespace AdmissionProcess.Services.Interface
{
	public interface IAdmissionFormServices
	{
		IEnumerable<AdmissionForm> GetAllAdmissionForms();
		int AddAdmissionForms(AdmissionForm admissionForm);
		AdmissionForm GetAdmissionFormById(int Student_ID);

		int UpdateAdmissionForms(AdmissionForm admissionForm);
		int DeleteAdmissionForms(int Student_ID);
	}
}
