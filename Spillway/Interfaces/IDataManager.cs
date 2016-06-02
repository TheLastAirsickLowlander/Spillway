﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillway.Interfaces
{
	/// <summary>
	///  This class wraps the data access from the other library and will also store all of the models for other classes to access from
	/// </summary>
	public interface IDataManager
	{
		bool RequestUserVerification();
		bool HasCurrentSessionOpen();
	}
}
