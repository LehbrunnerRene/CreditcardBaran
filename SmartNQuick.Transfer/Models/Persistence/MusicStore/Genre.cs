//@Ignore
using CommonBase.Extensions;
using SmartNQuick.Contracts.Persistence.MusicStore;

namespace SmartNQuick.Transfer.Models.Persistence.MusicStore
{
	public partial class Genre : VersionModel, Contracts.Persistence.MusicStore.IGenre
	{
		public string Name { get; set; }

		public void CopyProperties(IGenre other)
		{
			other.CheckArgument(nameof(other));

			Id = other.Id;
			RowVersion = other.RowVersion;
			Name = other.Name;
		}
	}
}
