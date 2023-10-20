using AdmissionProcess.Entity;

namespace AdmissionProcess.Repository.Interface
{
	public interface IAdmissionFormRepository
	{
		IEnumerable<AdmissionForm> GetAllAdmissionForms();

		AdmissionForm GetAdmissionFormById(int Student_ID);
		int AddAdmissionForms(AdmissionForm admissionForm);
		int UpdateAdmissionForms(AdmissionForm admissionForm);
		int DeleteAdmissionForms(int Student_ID);
	}
}
