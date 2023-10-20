using AdmissionProcess.Entity;
using AdmissionProcess.Repository.Interface;

namespace AdmissionProcess.Repository
{
	public class FeeStructureRepository : IFeeStructureRepository
	{
		private readonly ApplicationDbContext context;
		public FeeStructureRepository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public int AddFeeStructure(FeeStructure feeStructure)
		{
			int res = 0;
			context.FeeStructures.Add(feeStructure);
			res = context.SaveChanges();
			return res;
		}

		public int DeleteFeeStructure(int Payment_ID)
		{
			int res = 0;
			var register = context.FeeStructures.Where(x => x.Payment_ID == Payment_ID).FirstOrDefault();
			if (register != null)
			{

				res = context.SaveChanges();
			}
			return res;
		}

		public IEnumerable<FeeStructure> GetAllFeeStructures()
		{
			return context.FeeStructures.ToList();
		}

		public FeeStructure GetFeeStructureById(int Payment_ID)
		{
			int res = 0;
			var register = context.FeeStructures.Where(x => x.Payment_ID == Payment_ID).FirstOrDefault();
			return register;
		}

		public int UpdateFeeStructure(FeeStructure feeStructure)
		{
			int res = 0;
			var reg = context.FeeStructures.Where(x => x.Payment_ID == feeStructure.Payment_ID).FirstOrDefault();
			if (reg != null)
			{
				reg.Payment_options = feeStructure.Payment_options;
				reg.Current_status = feeStructure.Current_status;
				reg.Amount = feeStructure.Amount;
				reg.Student_ID = feeStructure.Student_ID;
				reg.Add_amount = feeStructure.Add_amount;
				res = context.SaveChanges();
			}
			return res;
		}
	}
}
