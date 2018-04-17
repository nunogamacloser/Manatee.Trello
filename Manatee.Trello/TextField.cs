﻿using Manatee.Trello.Internal;
using Manatee.Trello.Json;

namespace Manatee.Trello
{
	public class TextField : CustomField<string>
	{
		private readonly Field<string> _value;

		public override string Value
		{
			get { return _value.Value; }
			set { _value.Value = value; }
		}

		internal TextField(IJsonCustomField json, string cardId, TrelloAuthorization auth)
			: base(json, cardId, auth)
		{
			_value = new Field<string>(Context, nameof(IJsonCustomField.Text));
		}
	}
}