using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//required using statements
using ProjectTarunAgain;
using ProjectTarunAgain.Models;
using System.Web.ModelBinding;

namespace ProjectTarunAgain
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getGameData();
            }
        }

        protected void getGameData()
        {
            using (GameContext db = new GameContext())
            {
                var gameData = (from eachGame in db.GameTables select eachGame);
                GameGridView.DataSource = gameData.ToList();
                GameGridView.DataBind();


            }
        }
    }
}