﻿using System;

namespace GitHub
{
    public class Measurement
    {
        public Measurement(string name, bool success, TimeSpan controlDuration, TimeSpan candidateDuration)
        {
            Name = name;
            Success = success;
            ControlDuration = controlDuration;
            CandidateDuration = candidateDuration;
        }

        public bool Success { get; }
        public TimeSpan ControlDuration { get; }
        public TimeSpan CandidateDuration { get; }
        public string Name { get; }
     }
}
