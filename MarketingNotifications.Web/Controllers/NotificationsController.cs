using System.Threading.Tasks;
using System.Web.Mvc;
using MarketingNotifications.Web.Domain;
using MarketingNotifications.Web.Models.Repository;
using MarketingNotifications.Web.ViewModels;

namespace MarketingNotifications.Web.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly ISubscribersRepository _repository;
        private readonly IMessageSender _messageSender;

        public NotificationsController() : this(new SubscribersRepository(), new MessageSender())
        {
        }

        public NotificationsController(ISubscribersRepository repository, IMessageSender messageSender)
        {
            _messageSender = messageSender;
            _repository = repository;
        }

        // GET: Notifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notifications/Create
        [HttpPost]
        public async Task<ActionResult> Create(NotificationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Original code - Use this to send to ALL subscribers
                /*
                var subscribers = await _repository.FindActiveSubscribersAsync();
                subscribers.ForEach(subscriber =>
                {
                    _messageSender.Send(
                        subscriber.PhoneNumber,
                        model.Message,
                        model.ImageUrl);
                });

                ModelState.Clear();
                ViewBag.FlashMessage = "Messages on their way to RV Subscribers!";
                */

                

                if (!model.Rv && !model.Boat && !model.Bridal && !model.TestGroup)
                {
                    ViewBag.FlashMessage = "Please select a list.";
                }

                // sends to RV group only if RV group is ticked
                else if (model.Rv)
                {
                    var subscribers = await _repository.FindActiveRvListSubscribersAsync();
                    subscribers.ForEach(subscriber =>
                    {
                        _messageSender.Send(
                            subscriber.PhoneNumber,
                            model.Message,
                            model.ImageUrl);
                    });

                    ModelState.Clear();
                    ViewBag.FlashMessage = "Messages on their way to RV Subscribers!";
                }

                // sends to Boat group only if Boat checkbox is ticked
                else if (model.Boat)
                {
                    var subscribers = await _repository.FindActiveBoatListSubscribersAsync();
                    subscribers.ForEach(subscriber =>
                    {
                        _messageSender.Send(
                            subscriber.PhoneNumber,
                            model.Message,
                            model.ImageUrl);
                    });

                    ModelState.Clear();
                    ViewBag.FlashMessage = "Messages on their way to Boat Subscribers!";
                }

                //Sends to Bridal group only if Bridal group is ticked
                else if (model.Bridal)
                {
                    var subscribers = await _repository.FindActiveBridalListSubscribersAsync();
                    subscribers.ForEach(subscriber =>
                    {
                        _messageSender.Send(
                            subscriber.PhoneNumber,
                            model.Message,
                            model.ImageUrl);
                    });

                    ModelState.Clear();
                    ViewBag.FlashMessage = "Messages on their way to Bridal Subscribers!";
                }

                // Sends to Test Group only if Test Group checkbox is ticked.
                else if (model.TestGroup)
                {
                    var subscribers = await _repository.FindActiveTestListSubscribersAsync();
                    subscribers.ForEach(subscriber =>
                    {
                        _messageSender.Send(
                            subscriber.PhoneNumber,
                            model.Message,
                            model.ImageUrl);
                    });

                    ModelState.Clear();
                    ViewBag.FlashMessage = "Messages on their way to TEST Group Subscribers!";
                }
                
                return View();
            }

            return View(model);
        }
    }
}