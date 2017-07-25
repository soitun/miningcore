﻿using System;
using MiningForce.Configuration;

namespace MiningForce.Persistence.Model
{
	public class Balance
	{
		public string PoolId { get; set; }
		public CoinType Coin { get; set; }
		public string Address { get; set; }

		/// <summary>
		/// Amount owed in pool-base-currency (ie. Bitcoin, not Satoshis)
		/// </summary>
		public double Amount { get; set; }

		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}
