﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace statsd.net.Listeners
{
  public interface IListener
  {
    void LinkTo(ITargetBlock<string> target);
  }
}
