﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GeneratedSerializers;
using MallardMessageHandlers;

namespace ApplicationTemplate.Framework
{
	public class ObjectSerializerToResponseContentDeserializer : IResponseContentDeserializer
	{
		private readonly IObjectSerializer _objectSerializer;

		public ObjectSerializerToResponseContentDeserializer(IObjectSerializer objectSerializer)
		{
			_objectSerializer = objectSerializer ?? throw new ArgumentNullException(nameof(objectSerializer));
		}

		public async Task<TResponse> Deserialize<TResponse>(CancellationToken ct, HttpContent content)
		{
			if (content is null)
			{
				throw new ArgumentNullException(nameof(content));
			}

			using (var stream = await content.ReadAsStreamAsync())
			{
				return (TResponse)_objectSerializer.FromStream(stream, typeof(TResponse));
			}
		}
	}
}
