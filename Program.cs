﻿using System;
using NewReleases.ReleaseApp;

namespace NewReleases
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var release = new NewRelease();
			var results = release.Pull(new Uri("http://www.previewsworld.com/shipping/newreleases.txt"));
			Console.WriteLine($"{results} rows written to database.");
			Console.ReadLine();
		}
	}
}
