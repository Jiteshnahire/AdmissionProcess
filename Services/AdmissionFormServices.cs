using AdmissionProcess.Entity;
using AdmissionProcess.Repository;
using AdmissionProcess.Repository.Interface;
using AdmissionProcess.Services.Interface;
using Microsoft.Win32;

namespace AdmissionProcess.Services
{
	public class AdmissionFormServices : IAdmissionFormServices
	{
		private readonly IAdmissionFormRepository repository;
		public AdmissionFormServices(IAdmissionFormRepository repository)
		{
			this.repository = repository;
		}
		public int AddAdmissionForms(AdmissionForm admissionForm)
		{
			return repository.AddAdmissionForms(admissionForm);
		}

		public int DeleteAdmissionForms(int Student_ID)
		{
			return repository.DeleteAdmissionForms(Student_ID);
		}

		public IEnumerable<AdmissionForm> GetAllAdmissionForms()
		{
			return repository.GetAllAdmissionForms();
		}

		public AdmissionForm GetAdmissionFormById(int Student_ID)
		{
			return repository.GetAdmissionFormById(Student_ID);
		}

		public int UpdateAdmissionForms(AdmissionForm admissionForm)
		{
			return repository.UpdateAdmissionForms(admissionForm);
		}
	}
}
