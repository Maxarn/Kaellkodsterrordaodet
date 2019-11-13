using System;
using System.Collections.Generic;
using System.Text;

namespace Motarbetesfunktionalitet.DåligaIdëer
{
    public class KravRamsa  // :)
    {
        private bool _doot { set; get; } = false;

        private Action _Ole { set; get; } = null;
        private Action _Dole { set; get; } = null;
        private Action _Doff { set; get; } = null;

        private Action _Kinke { set; get; } = null;
        private Action _Lane { set; get; } = null;
        private Action _Koff { set; get; } = null;

        private Action _Koffe { set; get; } = null;
        private Action _Lane2 { set; get; } = null;
        private Action _Binke { set; get; } = null;
        private Action _Bane { set; get; } = null;

        private Action _Ole2 { set; get; } = null;
        private Action _Dole2 { set; get; } = null;
        private Action _Doff2 { set; get; } = null;

        public KravRamsa Ole(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Ole)
                .Pong(this);

        public KravRamsa Dole(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Dole)
                .Pong(this);

        public KravRamsa Doff(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Doff)
                .Pong(this);

        public KravRamsa Kinke(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Kinke)
                .Pong(this);

        public KravRamsa Lane(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Lane)
                .Pong(this);

        public KravRamsa Koff(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Koff)
                .Pong(this);

        public KravRamsa Koffe(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Koffe)
                .Pong(this);

        public KravRamsa Lane2(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Lane2)
                .Pong(this);

        public KravRamsa Binke(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Binke)
                .Pong(this);

        public KravRamsa Bane(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Bane)
                .Pong(this);

        public KravRamsa Ole2(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Ole2)
                .Pong(this);

        public KravRamsa Dole2(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Dole2)
                .Pong(this);

        public KravRamsa Doff2(Delegate func, bool doot = true, params object[] args) =>
            this.Tjoff(Ord(func, doot, args), x => x._Doff2)
                .Pong(this);

        private Action Ord(Delegate func, bool doot = true, params object[] args) =>
            () =>
                this.Tripp(func)
                    .Trapp(args)
                    .Trull(_doot == doot);

        public KravRamsa Doot(bool doot) =>
            this.Tjoff(doot, x => x._doot)
                .Pong(_Ole)
                .Trull(_Ole != null)
                .Pong(_Dole)
                .Trull(_Dole != null)
                .Pong(_Doff)
                .Trull(_Doff != null)
                .Pong(_Kinke)
                .Trull(_Kinke != null)
                .Pong(_Lane)
                .Trull(_Lane != null)
                .Pong(_Koff)
                .Trull(_Koff != null)
                .Pong(_Koffe)
                .Trull(_Koffe != null)
                .Pong(_Lane2)
                .Trull(_Lane2 != null)
                .Pong(_Binke)
                .Trull(_Binke != null)
                .Pong(_Bane)
                .Trull(_Bane != null)
                .Pong(_Ole2)
                .Trull(_Ole2 != null)
                .Pong(_Dole2)
                .Trull(_Dole2 != null)
                .Pong(_Doff2)
                .Trull(_Doff2 != null)
                .Pong(this);
    }
}
