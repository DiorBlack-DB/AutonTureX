using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.Model;
using WPFUIKitProfessional.Data.Classes.DataClasses;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFUIKitProfessional.Data.DBClasses
{
    internal class DBMethodsFromFavorite
    {
        public static ObservableCollection<RocketsX> GetRocketsX()
        {
            return new ObservableCollection<RocketsX>(DBConnection.connect.RocketsX);
        }
        public static ObservableCollection<RocketsXFavorite> GetRocketsXFavorites()
        {
            return new ObservableCollection<RocketsXFavorite>(DBConnection.connect.RocketsXFavorite);
        }
        //
        public static ObservableCollection<ShipsX> GetShipsX()
        {
            return new ObservableCollection<ShipsX>(DBConnection.connect.ShipsX);
        }
        public static ObservableCollection<ShipsFavorite> GetShipsXFavorites()
        {
            return new ObservableCollection<ShipsFavorite>(DBConnection.connect.ShipsFavorite);
        }
        //
        public static ObservableCollection<Model.ImageGetter> GetDateImage()
        {
            return new ObservableCollection<Model.ImageGetter>(DBConnection.connect.ImageGetter);
        }
        public static ObservableCollection<ImageDateFavorite> GetImageDateFavorite()
        {
            return new ObservableCollection<ImageDateFavorite>(DBConnection.connect.ImageDateFavorite);
        }
        //
        public static ObservableCollection<Model.Roadster> GetRoadster()
        {
            return new ObservableCollection<Model.Roadster>(DBConnection.connect.Roadster);
        }
        public static ObservableCollection<RoadsterFavorite> GetRoadsterFavorite()
        {
            return new ObservableCollection<RoadsterFavorite>(DBConnection.connect.RoadsterFavorite);
        }
        //
        public static ObservableCollection<Model.MarsRover> GetMarsRovers()
        {
            return new ObservableCollection<Model.MarsRover>(DBConnection.connect.MarsRover);
        }
        public static ObservableCollection<RoverFavorite> GetRoverFavorite()
        {
            return new ObservableCollection<RoverFavorite>(DBConnection.connect.RoverFavorite);
        }
        //
        public static ShipsX GetShipX(string name, string ship_model, string ship_type)
        {
            return GetShipsX().FirstOrDefault(s=>s.ship_name == name && s.ship_type == ship_type && s.ship_model == ship_model);
        }
        public static Model.ImageGetter GetImageGetter(string date)
        {
            return GetDateImage().FirstOrDefault(i=>i.date == date);
        }
        public static ImageDateFavorite GetImageDateFavorite(int idImage, int idClient)
        {
            return GetImageDateFavorite().FirstOrDefault(i => i.idClient == idClient && i.idImage == idImage);
        }
        public static ShipsFavorite GetShipFavorite(int idClient, int idShip)
        {
            return GetShipsXFavorites().FirstOrDefault(f=>f.idShips == idShip && f.idClient == idClient);
        }
        public static RocketsX GetRocketX(string name, int cost_per_launch)
        {
            return GetRocketsX().FirstOrDefault(r=>r.name ==name && r.cost_per_launch == cost_per_launch);
        }
        public static RocketsXFavorite GetRocketsXFavorite(int idRocket, int idClient)
        {
            return GetRocketsXFavorites().FirstOrDefault(f=>f.idRockets == idRocket && f.idClient == idClient);
        }
        public static void AddRocket(SpaceXRockets.Root rocket, string image1, string image2)
        {
            var getRocket = GetRocketX(rocket.rocket_name, rocket.cost_per_launch);
            if (getRocket == null)
            {
                imageRocketsX imageRockets = new imageRocketsX
                {
                    flickr_images1 = image1,
                    flickr_images2= image2
                };
                DBConnection.connect.imageRocketsX.Add(imageRockets);
                DBConnection.connect.SaveChanges();
                RocketsX rocketsX = new RocketsX
                {
                    name = rocket.rocket_name,
                    country = rocket.country,
                    active = rocket.active,
                    cost_per_launch = rocket.cost_per_launch,
                    first_flight = rocket.first_flight,
                    HeightMeters = rocket.height.meters,
                    DiameterMeters = rocket.diameter.meters,
                    mass = rocket.mass.lb,
                    boosters = rocket.boosters,
                    engines = rocket.engines.version,
                    idImage = imageRockets.id
                };
                DBConnection.connect.RocketsX.Add(rocketsX);
                DBConnection.connect.SaveChanges();
            }
        }
        public static void AddRocketFavorite(int idrocket, int idAccount)
        {
            var getFavorite = GetRocketsXFavorite(idrocket, idAccount);
            if (getFavorite == null)
            {
                RocketsXFavorite rocketsX = new RocketsXFavorite
                {
                    idClient = idAccount,
                    idRockets = idrocket
                };
                DBConnection.connect.RocketsXFavorite.Add(rocketsX);
                DBConnection.connect.SaveChanges();
                MessageBox.Show("add to favorite");
            }
            else
            {
                MessageBox.Show("has already been added");
                return;
            }
        }
        public static void AddShip(SpaceXShips.Root ships, string image1)
        {
            var getship = GetShipX(ships.ship_name, ships.ship_model, ships.ship_type);
            if (getship == null)
            {
                ImageShipsX imageShips = new ImageShipsX
                {
                    image1 = image1
                };
                DBConnection.connect.ImageShipsX.Add(imageShips);
                DBConnection.connect.SaveChanges();
                Model.ShipsX shipsX = new Model.ShipsX
                {
                    ship_name = ships.ship_name,
                    ship_model = ships.ship_model,
                    ship_type = ships.ship_type,
                    weight_kg = ships.weight_kg.ToString(),
                    year_built = ships.year_built.ToString(),
                    idImage = 0
                };
                DBConnection.connect.ShipsX.Add(shipsX);
                DBConnection.connect.SaveChanges();
            }
        }
        public static void AddFavoriteShip(int idship, int idclient)
        {
            var getfavorite = GetShipFavorite(idclient, idship);
            if (getfavorite == null)
            {
                ShipsFavorite ships = new ShipsFavorite
                {

                };
                DBConnection.connect.ShipsFavorite.Add(ships);
                DBConnection.connect.SaveChanges();
                MessageBox.Show("add to favorite");
            }
            else
            {
                MessageBox.Show("has already been added");
                return;
            }
        }
    }
}
