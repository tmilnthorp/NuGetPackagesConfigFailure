using System;
using UnitsNet;

namespace NuGetPackagesConfigFailure
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( Temperature.FromDegreesCelsius( 0.0 ) );
		}
	}
}
