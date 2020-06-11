﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IHM
{
    /// <summary>
    /// Cette classe définit l'API d'interface
    /// </summary>
    public interface IUsbManager
    {
        /// <summary>
        /// Fonction initialisant la ressource au niveau système
        /// </summary>
        /// <returns> pourquoi pas le FD, pour l'instant je fais comme ça</returns>
        void Init(Object context);

        /// <summary>
        /// Fonctions pour pouvoir afficher la liste des devices connecter
        /// </summary>
        /// <returns> une liste du nom de chaque connections </returns>
        ICollection<string> getListOfConnections();

        /// <summary>
        /// Fonction pour choisir le nom du device avec lequel effectuer la connection 
        /// </summary>
        /// <returns></returns>
        void selectDevice(string name);

        /// <summary>
        /// Fonctions retournant le FD 
        /// </summary>
        /// <returns>Le FD</returns>
        int getDeviceConnection();

        /// <summary>
        /// Fonction de désallocation des ressources
        /// </summary>
        /// <returns></returns>
        int Close();
    }
}