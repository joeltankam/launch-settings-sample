// `\n` passed as argument will be printed as new-line, even when wrapped in path classes
Console.WriteLine($"args[0]: {args[0]}");
Console.WriteLine($"new FileInfo(args[0]).FullName: {new FileInfo(args[0]).FullName}");
Console.WriteLine($"Path.GetFullPath(args[0]): {Path.GetFullPath(args[0])}");
