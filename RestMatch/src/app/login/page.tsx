"use client";

import Image from "next/image";
import React from "react";
import imageLogin from "../../../public/assets/images/login/login.jpg";

const Login = () => {

    return (
      <div className="py-16">
        <div className="flex bg-white rounded-2xl shadow-2xl overflow-hidden mx-auto max-w-sm lg:max-w-6xl">
          <div
            className="hidden lg:block lg:w-1/2 bg-cover"
            style={{
              backgroundImage: "url('/assets/images/login/login2.jpg')",
            }}
          ></div>
          <div className="box-shadow: 0 0 885px 885px rgba(0, 0, 0, 0.2) w-full p-8 lg:w-1/2 bg-[#A98660] pb-9">
            <p className="text-[32px] font-bold text-white-600 text-center">
              Welcome back!
            </p>

            <div className="mt-4 flex items-center justify-between">
              <span className="border-b w-1/5 lg:w-1/4"></span>
              <a
                href="#"
                className="text-[16px] text-center text-white-500 uppercase"
              >
                login with email
              </a>
              <span className="border-b w-1/5 lg:w-1/4"></span>
            </div>
            <div className="mt-4">
              <label className="text-[20px] block text-white-700 font-bold mb-2">
                Email Address
              </label>
              <input
                className="bg-white-200 text-black focus:outline-none focus:shadow-outline border border-black-300 rounded py-2 px-4 block w-full appearance-none"
                type="email"
              />
            </div>
            <div className="mt-4">
              <div className="flex justify-between">
                <label className="text-[20px] block text-white-700 font-bold mb-2">
                  Password
                </label>
                <a href="#" className="text-xs text-white-500">
                  Forget Password?
                </a>
              </div>
              <input
                className="bg-white-200 text-black focus:outline-none focus:shadow-outline border border-white-300 rounded py-2 px-4 block w-full appearance-none"
                type="password"
              />
            </div>
            <div className="mt-8">
              <button className=" rounded text-[20px] bg-[#565656] text-white font-bold py-2 px-10 w-full shadow-2xl">
                Login
              </button>
            </div>
            <div className="mt-4 flex items-center justify-between pb-5 pt-6">
              <span className="border-b w-1/5 md:w-1/4"></span>
              <a href="signup" className="text-[16px] text-white-500 uppercase">
                or <span className="underline font-bold">sign up</span>
              </a>
              <span className="border-b w-1/5 md:w-1/4"></span>
            </div>
          </div>
        </div>
      </div>
    );

}

export default Login;