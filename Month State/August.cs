﻿namespace WerewolfSim2k17.Month_State
{
    public class August : MonthState
    {
        private Player.Player player;
        private Main.MainSim sim;


        public August(Player.Player player, Main.MainSim sim)
        {
            this.player = player;
            this.sim = sim;
        }

        /// <summary>
        /// Gives buffs and debuffs based on the current month state
        /// The Sturgeon Moon
        /// </summary>
        public void fullMoon()
        {

        }

        /// <summary>
        /// Removes whatever buffs/debuffs that were given
        /// </summary>
        public void removeMoon()
        {

        }

        /// <summary>
        /// Changes to the next month
        /// For example August to September
        /// </summary>
        public void goNext()
        {
            removeMoon();
            sim.currState = new September(player, sim);
        }
    }
}