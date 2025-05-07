

// dotnet add package Microsoft.SemanticKernel
// dotnet add package Codeblaze.SemanticKernel.Connectors.Ollama 
using Codeblaze.SemanticKernel.Connectors.Ollama;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
var builder = Kernel.CreateBuilder()
                    .AddOllamaChatCompletion("qwen2.5-coder:latest",
                    "http://localhost:11434");



builder.Services.AddScoped<HttpClient>();
var kernel = builder.Build();

// Create a chat completion service with a history
var history = new ChatHistory();
while (true)
{
    Console.Write("Enter a prompt: ");
    string prompt = Console.ReadLine();
    history.AddUserMessage(prompt);
    IChatCompletionService chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
    var response = await chatCompletionService.GetChatMessageContentAsync(history);
    history.AddAssistantMessage(response.ToString());
    Console.WriteLine("Response: " + response.ToString());
}


// Create a function from a prompt with a specific promt template
var promtTemplate = "You are a .NET developer. Write a C# function that takes an integer as input and returns its square. The function should be named 'Square' and should be well-documented with comments explaining the code.";
var function = kernel.CreateFunctionFromPrompt(promtTemplate);
var arguments = new KernelArguments { ["Input"] = "Write factory pattern code with c#" };
var result = await function.InvokeAsync(kernel, arguments);
Console.WriteLine(result);


// Create a chat completion service
while (true)
{
    Console.WriteLine("Enter a prompt:");
    string prompt = Console.ReadLine();


    var response = await kernel.InvokePromptAsync(prompt);
    Console.WriteLine("Response:" + response);
}