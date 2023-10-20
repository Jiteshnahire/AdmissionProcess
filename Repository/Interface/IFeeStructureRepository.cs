using AdmissionProcess.Entity;

namespace AdmissionProcess.Repository.Interface
{
	public interface IFeeStructureRepository
	{
		IEnumerable<FeeStructure> GetAllFeeStructures();
		FeeStructure GetFeeStructureById(int Payment_ID);
		int AddFeeStructure(FeeStructure feeStructure);
		int UpdateFeeStructure(FeeStructure feeStructure);
		int DeleteFeeStructure(int Payment_ID);
	}
}
