﻿using Newtonsoft.Json;
using NPascalCoin.Processing;

// ReSharper disable InconsistentNaming

namespace NPascalCoin.DTO {
	public class SenderDTO {

		[JsonProperty("account")]
		public int Account { get; set; }

		/// <summary>
		/// N_Operation of Account
		/// </summary>
		[JsonProperty("n_operation")]
		public uint NOperation { get; set; }

		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		[JsonProperty("payload")]
		[JsonConverter(typeof(HexBinaryConverter))]
		public byte[] Payload { get; set; }
	}
}