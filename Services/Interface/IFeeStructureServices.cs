using AdmissionProcess.Entity;
using AdmissionProcess.Repository.Interface;

namespace AdmissionProcess.Services.Interface
{
	public interface IFeeStructureServices
	{
		IEnumerable<FeeStructure> GetAllFeeStructures();
		FeeStructure GetFeeStructureById(int Payment_ID);
		int AddFeeStructure(FeeStructure feeStructure);
		int UpdateFeeStructure(FeeStructure feeStructure);
		int DeleteFeeStructure(int Payment_ID);
	}
}
