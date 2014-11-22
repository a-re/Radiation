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
                    throw new Exception("what");
            }
        }

        public static string matchElement(int atomNum)
        {
            switch (atomNum)
            {
                case 1: return "H";
                case 2: return "H";
                case 3: return "H";
                case 4: return "H";
                case 5: return "H";
                case 6: return "H";
                case 7: return "H";
                case 8: return "H";
                case 9: return "H";
                case 10: return "H";
                case 11: return "H";
                case 12: return "H";
                case 13: return "H";
                case 14: return "H";
                case 15: return "H";
                case 16: return "H";
                case 17: return "H";
                case 18: return "H";
                case 19: return "H";
                case 20: return "H";
                case 21: return "H";
                case 22: return "H";
                case 23: return "H";
                case 24: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
                case 1: return "H";
            }
            return "";
        }
    }
}
