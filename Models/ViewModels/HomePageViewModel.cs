﻿using Save__plan_your_trips.Models.Domain;

namespace Save__plan_your_trips.Models.ViewModels;

public class HomePageViewModel
{
    public Album? Album { get; set; }
    public ScheduledTrip? ScheduledTrip { get; set; }
}