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
                    alphaList.Add(new Product(massNum - 4, atomNum - 2, doElementMatch(atomNum -2)));
                    alphaList.Add(new Product(4, 2, "He"));

                    return alphaList;
                case DecayMode.BetaDecay:
                    List<Product> betaList = new List<Product>();
                    betaList.Add(new Product(massNum, atomNum + 1, doElementMatch(atomNum + 1)));
                    betaList.Add(new Product(ProductType.Electron));
                    betaList.Add(new Product(ProductType.ElectronAntiVE));

                    return betaList;
                case DecayMode.ElectronCap:
                    List<Product> elecList = new List<Product>();
                    elecList.Add(new Product(massNum, atomNum - 1, doElementMatch(atomNum - 1)));
                    elecList.Add(new Product(ProductType.ElectronVE));

                    return elecList;
                case DecayMode.Positron:
                    List<Product> posList = new List<Product>();
                    posList.Add(new Product(massNum, atomNum - 1, doElementMatch(atomNum -1)));
                    posList.Add(new Product(ProductType.Positron));
                    posList.Add(new Product(ProductType.ElectronVE));

                    return posList;
                default:
                    throw new Exception("wtf man");
            }
        }

        public static string doElementMatch(int atomNum)
        {
            switch (atomNum)
            {
                case 1:
                    return "H";
                case 2:
                    return "He";
                case 3:
                    return "Li";
                case 4:
                    return "Be";
                case 5:
                    return "B";
                case 6:
                    return "C";
                case 7:
                    return "N";
                case 8:
                    return "O";
                case 9:
                    return "F";
                case 10:
                    return "Ne";
                case 11:
                    return "Na";
                case 12:
                    return "Mg";
                case 13:
                    return "Al";
                case 14:
                    return "Si";
                case 15:
                    return "";
                case 16:
                    return "";
                case 17:
                    return "";
                case 18:
                    return "";
                case 19:
                    return "";
                case 20:
                    return "";
                case 21:
                    return "";
                case 22:
                    return "";
                case 23:
                    return "";
                case 24:
                    return "";
                case 25:
                    return "";
                case 26:
                    return "";
                case 27:
                    return "";
                case 28:
                    return "";
                case 29:
                    return "";
                case 30:
                    return "";
                case 31:
                    return "";
                case 32:
                    return "";
                case 33:
                    return "";
                case 34:
                    return "";
                case 35:
                    return "";
                case 36:
                    return "";
                case 37:
                    return "";
                case 38:
                    return "";
                case 39:
                    return "";
                case 40:
                    return "";
                case 41:
                    return "";
                case 42:
                    return "";
                case 43:
                    return "";
                case 44:
                    return "";
                case 45:
                    return "";
                case 46:
                    return "";
                case 47:
                    return "";
                case 48:
                    return "";
                case 49:
                    return "";
                case 50:
                    return "";
            }
            return "";
        }
    }
}
