using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;


namespace Customer_Portal
{
    public class Program
    {
       static ITelegramBotClient botClient;

    static void Main(string[] args) {
      botClient = new TelegramBotClient("1887583425:AAHHTH9D2Oh5QitO3xrovU1hBvbV9q4Pz0s");

      var me = botClient.GetMeAsync().Result;
      Console.WriteLine(
        $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
        
      );

      botClient.OnMessage += Bot_OnMessage;
      botClient.StartReceiving();

      Console.WriteLine("Press any key to exit");
      Console.ReadKey();

      botClient.StopReceiving();

      CreateHostBuilder(args).Build().Run();
    }

    static async void Bot_OnMessage(object sender, MessageEventArgs e) {
      if (e.Message.Text != null)
      {
        Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

        await botClient.SendTextMessageAsync(
        chatId: e.Message.Chat,
        text:   "Hello, World!"
        );
        // Message message = await botClient.SendTextMessageAsync(
        // chatId: e.Message.Chat, // or a chat id: 123456789
        // text: "Trying *all the parameters* of `sendMessage` method",
        // parseMode: ParseMode.Markdown,
        // disableNotification: true,
        // replyToMessageId: e.Message.MessageId,
        // replyMarkup: new InlineKeyboardMarkup(InlineKeyboardButton.WithUrl(
        //     "Check sendMessage method",
        //     "https://core.telegram.org/bots/api#sendmessage"
        // ))
        // );
      }
    }


        // public static void Main(string[] args)
        // {
        //     CreateHostBuilder(args).Build().Run();
        // }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
