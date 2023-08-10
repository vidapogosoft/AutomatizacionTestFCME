public class TicketsTest
    {
        protected TestServer server;

        // Agregar una instancia para el servidor del test
        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Order(1)]
        [Test]
        public async Task InsertTicket_Test()
        {
            var _ticketAppService = server.Host.Services.GetService<ITicketsAppService>();

            var addTicket1 = await _ticketAppService.InsertTicketAsync(new TicketDTO() { PassengerId = 1, JourneyId = 1, Seat = 1 });
            var getTicket1 = await _ticketAppService.GetTicketAsync(addTicket1.Id);

            Assert.IsNotNull(addTicket1);
            Assert.AreEqual(addTicket1.PassengerId, getTicket1.PassengerId);
            Assert.AreEqual(addTicket1.JourneyId, getTicket1.JourneyId);
            Assert.AreEqual(addTicket1.Seat, getTicket1.Seat);


            var addTicket2 = await _ticketAppService.InsertTicketAsync(new TicketDTO() { PassengerId = 2, JourneyId = 2, Seat = 2 });
            var getTicket2 = await _ticketAppService.GetTicketAsync(addTicket2.Id);

            Assert.IsNotNull(addTicket2);
            Assert.AreEqual(addTicket2.PassengerId, getTicket2.PassengerId);
            Assert.AreEqual(addTicket2.JourneyId, getTicket2.JourneyId);
            Assert.AreEqual(addTicket2.Seat, getTicket2.Seat);

        }
        [Order(2)]
        [Test]
        public async Task GetAllTickets_Test()
        {
            var _ticketAppService = server.Host.Services.GetService<ITicketsAppService>();

            var insertFirst = await _ticketAppService.InsertTicketAsync(new TicketDTO() { PassengerId = 1, JourneyId = 1, Seat = 1 });
            var insertSecond = await _ticketAppService.InsertTicketAsync(new TicketDTO() { PassengerId = 2, JourneyId = 2, Seat = 2 });
            var insertThird = await _ticketAppService.InsertTicketAsync(new TicketDTO() { PassengerId = 3, JourneyId = 3, Seat = 3 });

            var list = await _ticketAppService.GetTicketsAsync();

            Assert.IsNotNull(list);
            Assert.AreEqual(list.Count, 3);
        }
        [Order(3)]
        [Test]
        public async Task EditTicket_Test()
        {
            var _ticketAppService = server.Host.Services.GetService<ITicketsAppService>();

            var originalTicket = new TicketDTO() { PassengerId = 1, JourneyId = 1, Seat = 1 };
            var insertEntity = await _ticketAppService.InsertTicketAsync(originalTicket);

            var editedTicket = new Ticket() { Id = insertEntity.Id, PassengerId = 2, JourneyId = 2, Seat = 2 };
            var updateEntity = await _ticketAppService.EditTicketAsync(editedTicket);

            var checkUpdate = await _ticketAppService.GetTicketAsync(insertEntity.Id);

            Assert.IsNotNull(originalTicket);
            Assert.AreNotEqual(originalTicket.PassengerId, checkUpdate.PassengerId);
            Assert.AreNotEqual(originalTicket.JourneyId, checkUpdate.JourneyId);
            Assert.AreNotEqual(originalTicket.Seat, checkUpdate.Seat);
        }
        [Order(4)]
        [Test]
        public async Task DeleteTicket_Test()
        {
            var _ticketAppService = server.Host.Services.GetService<ITicketsAppService>();

            var addTicket = await _ticketAppService.InsertTicketAsync(new TicketDTO() { PassengerId = 1, JourneyId = 1, Seat = 1 });

            await _ticketAppService.DeleteTicketAsync(addTicket.Id);
            var checkDelete = await _ticketAppService.GetTicketAsync(addTicket.Id);

            Assert.IsNull(checkDelete);
        }