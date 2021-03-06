//@Ignore
using CommonBase.Extensions;
using SmartNQuick.Contracts;
using SmartNQuick.Contracts.Client;
using SmartNQuick.Contracts.Persistence.Creditcard;
using SmartNQuick.Logic.Contracts;
using SmartNQuick.Logic.Controllers;

namespace SmartNQuick.Logic
{
	partial class Factory
	{
		static partial void CreateController<C>(IContext context, ref IControllerAccess<C> controller) where C : IIdentifiable
		{
			if (typeof(C) == typeof(SmartNQuick.Contracts.Persistence.MusicStore.IGenre))
			{
				controller = new Controllers.Persistence.MusicStore.GenreController(context) as IControllerAccess<C>;
			}
			else if (typeof(C) == typeof(SmartNQuick.Contracts.Persistence.MusicStore.IArtist))
			{
				controller = new Controllers.Persistence.MusicStore.ArtistController(context) as IControllerAccess<C>;
			}
			else if (typeof(C) == typeof(SmartNQuick.Contracts.Persistence.MusicStore.IAlbum))
			{
				controller = new Controllers.Persistence.MusicStore.AlbumController(context) as IControllerAccess<C>;
			}
			else if (typeof(C) == typeof(ICreditcard))
			{
				controller = new Controllers.Persistence.Creditcard.CreditcardController(context) as IControllerAccess<C>;
			}
		}
		static partial void CreateController<C>(ControllerObject controllerObject, ref IControllerAccess<C> controller) where C : IIdentifiable
		{
			controllerObject.CheckArgument(nameof(controllerObject));

			if (typeof(C) == typeof(SmartNQuick.Contracts.Persistence.MusicStore.IGenre))
			{
				controller = new Controllers.Persistence.MusicStore.GenreController(controllerObject) as IControllerAccess<C>;
			}
			else if (typeof(C) == typeof(SmartNQuick.Contracts.Persistence.MusicStore.IArtist))
			{
				controller = new Controllers.Persistence.MusicStore.ArtistController(controllerObject) as IControllerAccess<C>;
			}
			else if (typeof(C) == typeof(SmartNQuick.Contracts.Persistence.MusicStore.IAlbum))
			{
				controller = new Controllers.Persistence.MusicStore.AlbumController(controllerObject) as IControllerAccess<C>;
			}
			else if (typeof(C) == typeof(ICreditcard))
			{
				controller = new Controllers.Persistence.Creditcard.CreditcardController(controllerObject) as IControllerAccess<C>;
			}
		}
	}
}
