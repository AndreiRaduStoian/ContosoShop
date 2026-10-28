 using ContosoShop.Server.Data;
 using ContosoShop.Shared.Models;
 using ContosoShop.Shared.DTOs;
 using Microsoft.EntityFrameworkCore;

 namespace ContosoShop.Server.Services;

 /// <summary>
 /// Provides tool functions that the AI support agent can invoke
 /// to look up order information and process returns.
 /// </summary>
 public class SupportAgentTools
 {
     private readonly ContosoContext _context;
     private readonly IOrderService _orderService;
     private readonly IEmailService _emailService;
     private readonly ILogger<SupportAgentTools> _logger;

     public SupportAgentTools(
         ContosoContext context,
         IOrderService orderService,
         IEmailService emailService,
         ILogger<SupportAgentTools> logger)
     {
         _context = context;
         _orderService = orderService;
         _emailService = emailService;
         _logger = logger;
     }

     // add the `GetOrderDetailsAsync` method here


     // add the `GetUserOrdersSummaryAsync` method here


     // add the `ProcessReturnAsync` method here


     // add the `SendCustomerEmailAsync` method here

 }
