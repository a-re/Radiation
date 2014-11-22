using System;
using System.Collections.Generic;

namespace radiation_checker
{
    public class Product
    {
        public enum DecayMode
        {
            AlphaDecay, BetaDecay, Positron, ElectronCap
        }

        public enum ProductType
        {
            Element, Positron, ElectronAntiVE, ElectronVE, Electron
        }

        int massNum;
        int atomNum;
        string symbol;

        string fullName = "Element";
        public ProductType type = ProductType.Element;

        public Product(int massNum, int atomNum, string symbol)
        {
            this.massNum = massNum;
            this.atomNum = atomNum;
            this.symbol = symbol;
        }

        public Product(ProductType type)
        {
            this.type = type;

            switch (type)
            {
                case ProductType.Electron:
                    massNum = 0;
                    atomNum = -1;
                    symbol = "e-";
                    fullName = "Electron";
                    break;
                case ProductType.Positron:
                    massNum = 0;
                    atomNum = -1;
                    symbol = "e+";
                    fullName = "Positron";
                    break;
                case ProductType.ElectronVE:
                    massNum = 0;
                    atomNum = 0;
                    symbol = "νe";
                    fullName = "Electron neutrino";
                    break;
                case ProductType.ElectronAntiVE:
                    massNum = 0;
                    atomNum = 0;
                    symbol = " ̅νe";
                    fullName = "Electron anti-neutrino";
                    break;
            }
        }

        public int getMassNum()
        {
            return massNum;
        }

        public int getAtomNum()
        {
            return atomNum;
        }

        public string getSymbol()
        {
            return symbol;
        }

        public string getFullName()
        {
            return fullName;
        }

        public List<Product> doDecay(DecayMode mode)
        {
            switch (mode)
            {
                case DecayMode.AlphaDecay:
                    List<Product> alphaList = new List<Product>();
                    alphaList.Add(new Product(massNum - 4, atomNum - 2, matchElement(atomNum -2)));
                    alphaList.Add(new Product(4, 2, "He"));

                    return alphaList;
                case DecayMode.BetaDecay:
                    List<Product> betaList = new List<Product>();
                    betaList.Add(new Product(massNum, atomNum + 1, matchElement(atomNum + 1)));
                    betaList.Add(new Product(ProductType.Electron));
                    betaList.Add(new Product(ProductType.ElectronAntiVE));

                    return betaList;
                case DecayMode.ElectronCap:
                    List<Product> elecList = new List<Product>();
                    elecList.Add(new Product(massNum, atomNum - 1, matchElement(atomNum - 1)));
                    elecList.Add(new Product(ProductType.ElectronVE));

                    return elecList;
                case DecayMode.Positron:
                    List<Product> posList = new List<Product>();
                    posList.Add(new Product(massNum, atomNum - 1, matchElement(atomNum -1)));
                    posList.Add(new Product(ProductType.Positron));
                    posList.Add(new Product(ProductType.ElectronVE));

                    return posList;
                default:
                    throw new Exception("what");
            }
        }

        public static string matchElement(int atomNum)
        {
            switch (atomNum)
            {
                case 1: return "H";
                case 2: return "He";
                case 3: return "Li";
                case 4: return "Be";
                case 5: return "B";
                case 6: return "C";
                case 7: return "N";
                case 8: return "O";
                case 9: return "F";
                case 10: return "Ne";
                case 11: return "Na";
                case 12: return "Mg";
                case 13: return "Al";
                case 14: return "Si";
                case 15: return "P";
                case 16: return "S";
                case 17: return "Cl";
                case 18: return "Ar";
                case 19: return "K";
                case 20: return "Ca";
                case 21: return "Sc";
                case 22: return "Ti";
                case 23: return "V";
                case 24: return "Cr";
                case 25: return "Mn";
                case 26: return "Fe";
                case 27: return "Co";
                case 28: return "Ni";
                case 29: return "Cu";
                case 30: return "Zn";
                case 31: return "Ga";
                case 32: return "Ge";
                case 33: return "As";
                case 34: return "Se";
                case 35: return "Br";
                case 36: return "Kr";
                case 37: return "Rb";
                case 38: return "Sr";
                case 39: return "Y";
                case 40: return "Zr";
                case 41: return "Nb";
                case 42: return "Mo";
                case 43: return "Tc";
                case 44: return "Ru";
                case 45: return "Rh";
                case 46: return "Pd";
                case 47: return "Ag";
                case 48: return "Cd";
                case 49: return "In";
                case 50: return "Sn";
                case 51: return "Sb";
                case 52: return "Te";
                case 53: return "I";
                case 54: return "Xe";
                case 55: return "Cs";
                case 56: return "Ba";
                case 57: return "La";
                case 58: return "Ce";
                case 59: return "Pr";
                case 60: return "Nd";
            }
            return "";
        }
    }
}
