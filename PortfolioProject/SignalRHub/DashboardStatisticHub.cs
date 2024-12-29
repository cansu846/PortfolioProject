using BusinessLayer.Abstract;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.SignalRHub
{
    public class DashboardStatisticHub : Hub
    {
        private readonly IWriterUserService _writerUserService;
        private readonly IUserMessageService _userMessageService;
        private readonly IPortfolioService _portfolioService;
        private readonly IAnnouncementService _announcementService;
        public DashboardStatisticHub(IWriterUserService writerUserService,
            IUserMessageService userMessageService,
            IPortfolioService portfolioService,
            IAnnouncementService announcementService)
        {
            _writerUserService = writerUserService;
            _userMessageService = userMessageService;
            _portfolioService = portfolioService;
            _announcementService = announcementService;
        }
        public async Task SendTotalUser()
        {
            var totalUser = _writerUserService.GetAll().Count();
            await Clients.All.SendAsync("ReceiveTotalUser", totalUser);
        }

        public async Task SendTotalMessage()
        {
            var totalMessage = _userMessageService.GetUserMessageWithUser().Count();
            await Clients.All.SendAsync("ReceiveTotalMessage", totalMessage);
        }
        public async Task SendTotalProject()
        {
            var totalProject = _portfolioService.GetAll().Count();
            await Clients.All.SendAsync("ReceiveTotalProject", totalProject);
        }

        public async Task SendTotalAnnouncement()
        {
            var totalAnnouncement = _announcementService.GetAll().Count();
            await Clients.All.SendAsync("ReceiveTotalAnnouncement", totalAnnouncement);
            Console.WriteLine(totalAnnouncement);
        }
    }
}
