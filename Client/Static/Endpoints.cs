﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel_Itinerary.Client.Static
{
	public static class Endpoints
	{
		private static readonly string Prefix = "api";

		public static readonly string TravelDocsEndpoint = $"{Prefix}/traveldocs";
		public static readonly string DestinationEndpoint = $"{Prefix}/destination";
		public static readonly string CustomersEndpoint = $"{Prefix}/customers";
		public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
	}
}
