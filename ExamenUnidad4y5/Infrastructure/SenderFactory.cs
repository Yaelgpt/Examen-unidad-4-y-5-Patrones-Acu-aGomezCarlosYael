namespace NotificacionesWinForms.Infrastructure
{
    public static class SenderFactory
    {
        public static ISender Create(int canal)
        {
            switch (canal)
            {
                case 1: return new AppSender();
                case 2: return new EmailSender();
                default: return new AppSender();
            }
        }
    }
}
