using AdmissionProcess.Entity;
using AdmissionProcess.Repository.Interface;
using Microsoft.Win32;

namespace AdmissionProcess.Repository
{
	public class AdmissionFormRepository : IAdmissionFormRepository
	{
		private readonly ApplicationDbContext context;
		public AdmissionFormRepository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public int AddAdmissionForms(AdmissionForm admissionForm)
		{
			int res = 0;
			context.AdmissionForms.Add(admissionForm);
			res = context.SaveChanges();
			return res;
		}

		public int DeleteAdmissionForms(int Student_ID)
		{
			int res = 0;
			var register = context.AdmissionForms.Where(x => x.Student_ID == Student_ID).FirstOrDefault();
			if (register != null)
			{
			
				res = context.SaveChanges();
			}
			return res;
		}

		public AdmissionForm GetAdmissionFormById(int Student_ID)
		{
			int res = 0;
			var register = context.AdmissionForms.Where(x => x.Student_ID == Student_ID).FirstOrDefault();
			return register;
		}

		public IEnumerable<AdmissionForm> GetAllAdmissionForms()
		{
			return context.AdmissionForms.ToList();
		}

		public int UpdateAdmissionForms(AdmissionForm admissionForm)
		{
			int res = 0;
			var reg = context.AdmissionForms.Where(x => x.Student_ID == admissionForm.Student_ID).FirstOrDefault();
			if (reg != null)
			{
				reg.Fullname = admissionForm.Fullname;
				reg.Email = admissionForm.Email;
				reg.Age = admissionForm.Age;
				reg.Gender = admissionForm.Gender;
				reg.DOB = admissionForm.DOB;
				reg.Mobile = admissionForm.Mobile;
				reg.Address = admissionForm.Address;
				reg.Percentage = admissionForm.Percentage;
				reg.GPA = admissionForm.GPA;
				reg.Branch = admissionForm.Branch;
				reg.Religion = admissionForm.Religion;
				reg.Previous_College = admissionForm.Previous_College;
				reg.Enrollment_date = admissionForm.Enrollment_date;
				reg.Password = admissionForm.Password;
				reg.Fee = admissionForm.Fee;
				reg.Education = admissionForm.Education;
				reg.Student_status = admissionForm.Student_status;
				reg.Form_status = admissionForm.Form_status;
				res = context.SaveChanges();
			}
			return res;
		}
	}
}
