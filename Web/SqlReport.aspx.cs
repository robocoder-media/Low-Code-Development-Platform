using System;
            Page.PreInit += new EventHandler(Page_PreInit);
            Page.Init += new System.EventHandler(Page_Init);
        }


        void Page_PreInit(object sender, EventArgs e)
        {
            SetMasterPage();
        }
        