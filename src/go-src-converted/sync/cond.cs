// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package sync -- go2cs converted at 2020 August 29 08:16:21 UTC
// import "sync" ==> using sync = go.sync_package
// Original source: C:\Go\src\sync\cond.go
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class sync_package
    {
        // Cond implements a condition variable, a rendezvous point
        // for goroutines waiting for or announcing the occurrence
        // of an event.
        //
        // Each Cond has an associated Locker L (often a *Mutex or *RWMutex),
        // which must be held when changing the condition and
        // when calling the Wait method.
        //
        // A Cond must not be copied after first use.
        public partial struct Cond
        {
            public noCopy noCopy; // L is held while observing or changing the condition
            public Locker L;
            public notifyList notify;
            public copyChecker checker;
        }

        // NewCond returns a new Cond with Locker l.
        public static ref Cond NewCond(Locker l)
        {
            return ref new Cond(L:l);
        }

        // Wait atomically unlocks c.L and suspends execution
        // of the calling goroutine. After later resuming execution,
        // Wait locks c.L before returning. Unlike in other systems,
        // Wait cannot return unless awoken by Broadcast or Signal.
        //
        // Because c.L is not locked when Wait first resumes, the caller
        // typically cannot assume that the condition is true when
        // Wait returns. Instead, the caller should Wait in a loop:
        //
        //    c.L.Lock()
        //    for !condition() {
        //        c.Wait()
        //    }
        //    ... make use of condition ...
        //    c.L.Unlock()
        //
        private static void Wait(this ref Cond c)
        {
            c.checker.check();
            var t = runtime_notifyListAdd(ref c.notify);
            c.L.Unlock();
            runtime_notifyListWait(ref c.notify, t);
            c.L.Lock();
        }

        // Signal wakes one goroutine waiting on c, if there is any.
        //
        // It is allowed but not required for the caller to hold c.L
        // during the call.
        private static void Signal(this ref Cond c)
        {
            c.checker.check();
            runtime_notifyListNotifyOne(ref c.notify);
        }

        // Broadcast wakes all goroutines waiting on c.
        //
        // It is allowed but not required for the caller to hold c.L
        // during the call.
        private static void Broadcast(this ref Cond c)
        {
            c.checker.check();
            runtime_notifyListNotifyAll(ref c.notify);
        }

        // copyChecker holds back pointer to itself to detect object copying.
        private partial struct copyChecker // : System.UIntPtr
        {
        }

        private static void check(this ref copyChecker _c) => func(_c, (ref copyChecker c, Defer _, Panic panic, Recover __) =>
        {
            if (uintptr(c.Value) != uintptr(@unsafe.Pointer(c)) && !atomic.CompareAndSwapUintptr((uintptr.Value)(c), 0L, uintptr(@unsafe.Pointer(c))) && uintptr(c.Value) != uintptr(@unsafe.Pointer(c)))
            {
                panic("sync.Cond is copied");
            }
        });

        // noCopy may be embedded into structs which must not be copied
        // after the first use.
        //
        // See https://golang.org/issues/8005#issuecomment-190753527
        // for details.
        private partial struct noCopy
        {
        }

        // Lock is a no-op used by -copylocks checker from `go vet`.
        private static void Lock(this ref noCopy _p0)
        {
        }
    }
}