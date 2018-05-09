﻿using System;
using System.Collections.Generic;

namespace MikValSor.Immutable
{
    internal sealed class ResultCache
    {
		private readonly Dictionary<string, TypeImmutableValidationResult> TypeResults = new Dictionary<string, TypeImmutableValidationResult>()
		{
			{typeof(int).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(bool).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(byte).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(char).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(decimal).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(double).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(float).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(long).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(sbyte).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(short).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(string).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(uint).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(ulong).FullName, TypeImmutableValidationResult.IsImmutable },
			{typeof(ushort).FullName, TypeImmutableValidationResult.IsImmutable }
		};
		private readonly Dictionary<string, bool> InstanceResults = new Dictionary<string, bool>()
		{
			{typeof(int).FullName, true },
			{typeof(bool).FullName, true },
			{typeof(byte).FullName, true },
			{typeof(char).FullName, true },
			{typeof(decimal).FullName, true },
			{typeof(double).FullName, true },
			{typeof(float).FullName, true },
			{typeof(long).FullName, true },
			{typeof(sbyte).FullName, true },
			{typeof(short).FullName, true },
			{typeof(string).FullName, true },
			{typeof(uint).FullName, true },
			{typeof(ulong).FullName, true },
			{typeof(ushort).FullName, true }
		};
		private readonly Dictionary<string, TypeImmutableValidationResult> BaseTypeResults = new Dictionary<string, TypeImmutableValidationResult>();
		private readonly Dictionary<string, bool> BaseInstanceResults = new Dictionary<string, bool>();
		private Dictionary<string, bool> GetResults(bool instance, bool baseType)
		{
			Dictionary<string, bool> results;
			if (baseType)
			{
				results = instance ? BaseInstanceResults : BaseTypeResults;
			}
			else
			{
				results = instance ? InstanceResults : TypeResults;
			}
			return results;

		}

		private readonly object InsertionLockObject = new object();
		
		internal bool TryGetResult(Type type, bool instance, bool baseType, out bool result)
		{
			Dictionary<string, bool> results;
			if (baseType)
			{
				results = instance ? BaseInstanceResults : BaseTypeResults;
			}
			else
			{
				results = instance ? InstanceResults : TypeResults;
			}

			return results.TryGetValue(type.FullName, out result);
		}


		internal void AddResult(Type type, bool instance, bool result)
		{
			var results = instance ? InstanceResults : TypeResults;
			var name = type.FullName;

			if (results.ContainsKey(name)) return;

			lock (InsertionLockObject)
			{
				if (results.ContainsKey(name)) return;
				results.Add(name, result);
			}
		}
	}
}
