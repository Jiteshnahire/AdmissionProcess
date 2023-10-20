using AdmissionProcess.Entity;
using AdmissionProcess.Repository.Interface;
using AdmissionProcess.Services.Interface;

namespace AdmissionProcess.Services
{
	public class FeeStructureServices : IFeeStructureServices
	{
		private readonly IFeeStructureRepository repository;
		public FeeStructureServices(IFeeStructureRepository repository)
		{
			this.repository = repository;
		}
		public int AddFeeStructure(FeeStructure feeStructure)
		{
			return repository.AddFeeStructure(feeStructure);
		}

		public int DeleteFeeStructure(int Payment_ID)
		{
			return repository.DeleteFeeStructure(Payment_ID);
		}

		public IEnumerable<FeeStructure> GetAllFeeStructures()
		{
			return repository.GetAllFeeStructures();
		}

		public FeeStructure GetFeeStructureById(int Payment_ID)
		{
			return repository.GetFeeStructureById(Payment_ID);
		}

		public int UpdateFeeStructure(FeeStructure feeStructure)
		{
			return repository.UpdateFeeStructure(feeStructure);
		}
	}
}
