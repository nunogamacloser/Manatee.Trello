﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Manatee.Trello.Internal.Caching;
using Manatee.Trello.Internal.DataAccess;
using Manatee.Trello.Json;

namespace Manatee.Trello
{
	/// <summary>
	/// A read-only collectin of boards.
	/// </summary>
	public class ReadOnlyStarredBoardCollection : ReadOnlyCollection<IStarredBoard>
	{
		internal ReadOnlyStarredBoardCollection(Func<string> getOwnerId, TrelloAuthorization auth)
			: base(getOwnerId, auth)
		{
		}

		internal sealed override async Task PerformRefresh(bool force, CancellationToken ct)
		{
			IncorporateLimit();

			var endpoint = EndpointFactory.Build(EntityRequestType.Member_Read_StarredBoards, new Dictionary<string, object> {{"_id", OwnerId}});
			var newData = await JsonRepository.Execute<List<IJsonStarredBoard>>(Auth, endpoint, ct, AdditionalParameters);

			Items.Clear();
			Items.AddRange(newData.Select(jb =>
				{
					var board = jb.GetFromCache<StarredBoard, IJsonStarredBoard>(Auth);
					board.Json = jb;
					return board;
				}));
		}
	}
}