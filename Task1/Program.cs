using Task1;

string inputSentence = "The 'C# Professional' course includes the topics I discuss in my CLR via C# book and teaches how the CLR works thereby showing you how to develop applications and reusable components for the .NET Framework.";

WordGrouping wordGroupingService = new WordGrouping(inputSentence);
wordGroupingService.GroupWordsByLength();