"use client";

import { useState } from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBars, faTimes } from "@fortawesome/free-solid-svg-icons";
import Image from "next/image";
import { imageUrl } from "@/utils/constants";

const HeaderM = () => {
  const [nav, setNav] = useState(false);
  return (
    <header>
      <nav className="bg-[#352414] fixed top-0 left-0 right-0 h-[67px] w-full pt-[12px] pb-[15px] px-3 z-[110]  w-full border-gray-200 px-4 lg:px-6 py-2.5 dark:bg-gray-800 shadow">
        <div className="flex flex-wrap justify-between items-center mx-auto max-w-screen-lg ">
          <button className="flex items-center">
            <span className="self-center text-xl font-semibold whitespace-nowrap dark:text-">
              <Image
                width="98"
                height="34"
                src={`${imageUrl}/header/logo.png`}
                alt="logo"
              />
            </span>
          </button>

          <div
            className={`flex-col  md:flex md:flex-row items-left w-full md:w-auto md:order-2 transition-all duration-300 ${
              nav
                ? "absolute top-14 right-0 w-full bg-[#352414] shadow-md p-4 md:relative md:top-0 md:w-auto md:bg-transparent md:shadow-none"
                : "hidden md:flex gap-6"
            }`}
          >
            <ul className="flex flex-col justify-end md:flex-row md:gap-8 gap-0">
              <li>
                <button className="bg-[#191919]/10 block py-2 pr-4 pl-3 text-white border-b border-white-100 hover:bg-[#5D462D] md:hover:bg-transparent md:border-0 md:hover:text-primary-700 md:px-2 md:py-0.5 dark:text-gray-400 md:dark:hover:text-white dark:hover:bg-gray-700 dark:hover:text-white md:dark:hover:bg-transparent dark:border-gray-700">
                  Home page
                </button>
              </li>
              <li>
                <button className="block py-2 pr-4 pl-3 text-white border-b border-gray-100 hover:bg-[#5D462D] md:hover:bg-transparent md:border-0 md:hover:text-primary-700 md:p-0 dark:text-gray-400 md:dark:hover:text-white dark:hover:bg-gray-700 dark:hover:text-white md:dark:hover:bg-transparent dark:border-gray-700">
                  Let`s Match
                </button>
              </li>
              <li>
                <button className="block py-2 pr-4 pl-3 text-white border-b border-gray-100 hover:bg-[#5D462D] md:hover:bg-transparent md:border-0 md:hover:text-primary-700 md:p-0 dark:text-gray-400 md:dark:hover:text-white dark:hover:bg-gray-700 dark:hover:text-white md:dark:hover:bg-transparent dark:border-gray-700">
                  Research
                </button>
              </li>
              <li>
                <button className="block py-2 pr-4 pl-3 text-white border-b border-gray-100 hover:bg-[#5D462D] md:hover:bg-transparent md:border-0 md:hover:text-primary-700 md:p-0 dark:text-gray-400 md:dark:hover:text-white dark:hover:bg-gray-700 dark:hover:text-white md:dark:hover:bg-transparent dark:border-gray-700">
                  Settings
                </button>
              </li>
              {/* Add more links here */}
            </ul>
            <button
              className="mt-4 md:mt-0 rounded-full bg-[#5D462D] py-2 px-4 border border-transparent text-center text-sm text-white transition-all shadow-md hover:shadow-lg focus:bg-slate-700"
              type="button"
            >
              Sign Up Now
            </button>
          </div>

          {/* Hamburger Icon */}
          <div className="md:hidden flex items-center lg:order-1">
            <button
              type="button"
              className="inline-flex items-center p-2 text-sm text-[#9F784E] rounded-lg hover:bg-[#9F784E] focus:outline-none"
              aria-controls="mobile-menu"
              aria-expanded={nav}
              onClick={() => setNav(!nav)}
            >
              <span className="sr-only">Open main menu</span>
              {nav ? (
                <FontAwesomeIcon
                  icon={faTimes}
                  className="w-6 h-6 text-white"
                />
              ) : (
                <FontAwesomeIcon icon={faBars} className="w-6 h-6 text-white" />
              )}
            </button>
          </div>
        </div>
      </nav>
    </header>
  );
};

export default HeaderM;
