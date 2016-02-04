using System.Collections.Generic;
using HipchatApiV2;
using HipchatApiV2.Enums;
using HipchatApiV2.Requests;

namespace TestApplication
{
  internal class Program
  {
    private static void Main()
    {
      HipchatClient hipchatClient = new HipchatClient("1KoQTmxVnWZDcHObCfPKKKvMnR9msOlX4Wn54fJG");

      var r = hipchatClient.SendNotification(2259497, new SendRoomNotificationRequest
      {
        MessageFormat = HipchatMessageFormat.Text,
        Message = "Hello :) (yey)",
        Color = RoomColors.Green,
        Notify = true
      });
    }
  }
}