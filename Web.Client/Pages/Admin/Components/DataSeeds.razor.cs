﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;
using Havit.NewProjectTemplate.Contracts.System;
using Microsoft.AspNetCore.Components;

namespace Havit.NewProjectTemplate.Web.Client.Pages.Admin.Components
{
	public partial class DataSeeds : ComponentBase
	{
		[Inject] protected IDataSeedFacade DataSeedFacade { get; set; }
		[Inject] protected IHxMessengerService Messenger { get; set; }
		[Inject] protected IHxMessageBoxService MessageBox { get; set; }

		private IEnumerable<string> seedProfiles;
		private string selectedSeedProfile;
		private HxOffcanvas offcanvasComponent;

		private async Task HandleSeedClick()
		{
			if (selectedSeedProfile is not null && await MessageBox.ConfirmAsync($"Do you really want to seed {selectedSeedProfile}?"))
			{
				await DataSeedFacade.SeedDataProfile(selectedSeedProfile);
				Messenger.AddInformation($"Seed successful: {selectedSeedProfile}");

				await offcanvasComponent.HideAsync();
			}
		}

		public async Task ShowAsync()
		{
			seedProfiles ??= (await DataSeedFacade.GetDataSeedProfiles()).Value;

			await offcanvasComponent.ShowAsync();
		}
	}
}
