"use client";

import React from "react";
import { useState } from "react";
import { Eye, EyeOff } from "lucide-react";
import {Routes} from "@/types/routes";
import authService from "@/services/auth.service";
import {AuthUserRegistration} from "@/models/AuthUser";
import {useRouter} from "next/navigation";

interface FormData {
  name: string;
  nickname: string;
  email: string;
  password: string;
}

const SignUp = () => {
    const [formData, setFormData] = useState<FormData>({
      name: "",
      nickname: "",
      email: "",
      password: "",
    });

    const [errors, setErrors] = useState<Record<string, string>>({});
    const [showPassword, setShowPassword] = useState(false);

    const router = useRouter();

    const validate = () => {
      const newErrors: Record<string, string> = {};
      // Перевірка імені
      if (!formData.name) {
        newErrors.name = "Name is required.";
      } else if (formData.name.length < 3) {
        newErrors.name = "Name must be at least 3 characters long.";
      }

      // Перевірка нікнейму
      if (!formData.nickname) {
        newErrors.nickname = "Nickname is required.";
      }

      // Перевірка пошти
      if (!formData.email) {
        newErrors.email = "Email is required.";
      } else if (!/^\S+@\S+\.\S+$/.test(formData.email)) {
        newErrors.email = "Invalid email format.";
      }

      // Перевірка пароля
      if (!formData.password) {
        newErrors.password = "Password is required.";
      } else if (formData.password.length < 6) {
        newErrors.password = "Password must be at least 6 characters long.";
      }

      setErrors(newErrors);
      return Object.keys(newErrors).length === 0; // Якщо помилок немає
    };

    const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
      e.preventDefault();
      if (validate()) {
        const firstAndLastName = formData.name.split(' ');

        const payload: AuthUserRegistration = {
          firstName: firstAndLastName[0],
          lastName: firstAndLastName[1],
          nickname: formData.nickname,
          email: formData.email,
          password: formData.password,
          roles: [1]
        }
        const response = await authService.signUp(payload);
        authService.setToken(response.data);
        router.push(Routes.HOME);
      }
    };

    const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) => {
      const { name, value } = e.target;
      setFormData((prevData) => ({ ...prevData, [name]: value }));
    };


    return (
      <div className="py-16">
        <div className="flex bg-white rounded-2xl shadow-2xl overflow-hidden mx-auto max-w-sm lg:max-w-6xl">
          <form
            onSubmit={handleSubmit}
            className="box-shadow: 0 0 885px 885px rgba(0, 0, 0, 0.2) w-full p-8 lg:w-1/2 bg-[#A98660] pb-9"
          >
            <p className="text-[32px] font-bold text-white-600 text-center">
              Create your account
            </p>
            <div className="text-center p-2">
              <a href={Routes.LOGIN} className="text-[16px] text-gray-300 ">
                Already have an account?{" "}
                <span className="text-white font-bold underline">Log in</span>
              </a>
            </div>
            <div className="mt-4">
              <label className="text-[20px] block text-white-700 font-bold mb-2">
                First name and Last name
              </label>
              <input
                type="text"
                name="name"
                value={formData.name}
                onChange={handleInputChange}
                className="bg-white-200 text-black focus:outline-none focus:shadow-outline border border-white-300 rounded py-2 px-4 block w-full appearance-none"
              />
              {errors.name && (
                <p className="text-red-500 text-sm mt-1">{errors.name}</p>
              )}
            </div>
            <div className="mt-4">
              <div className="flex justify-between">
                <label className="text-[20px] block text-white-700 font-bold mb-2">
                  Nickname
                </label>
              </div>
              <input
                type="text"
                name="nickname"
                value={formData.nickname}
                onChange={handleInputChange}
                className="bg-white-200 text-black focus:outline-none focus:shadow-outline border border-white-300 rounded py-2 px-4 block w-full"
              />
              {errors.nickname && (
                <p className="text-red-500 text-sm mt-1">{errors.nickname}</p>
              )}
            </div>
            <div className="mt-4">
              <div className="flex justify-between">
                <label className="text-[20px] block text-white-700 font-bold mb-2">
                  Email address
                </label>
              </div>
              <input
                type="email"
                name="email"
                value={formData.email}
                onChange={handleInputChange}
                className="bg-white-200 text-black focus:outline-none focus:shadow-outline border border-white-300 rounded py-2 px-4 block w-full "
              />
              {errors.email && (
                <p className="text-red-500 text-sm mt-1">{errors.email}</p>
              )}
            </div>
            <div className="relative mt-4">
              <div className="flex justify-between">
                <label className="text-[20px] block text-white-700 font-bold mb-2">
                  Password
                </label>
              </div>
              <input
                type={showPassword ? "text" : "password"}
                name="password"
                value={formData.password}
                onChange={handleInputChange}
                className="bg-white-200 text-black focus:outline-none focus:shadow-outline border border-white-300 rounded py-2 px-4 block w-full appearance-none"
              />
              {formData.password && (
                <button
                  type="button"
                  onClick={() => setShowPassword((prev) => !prev)}
                  className="absolute inset-y-0 right-2 flex items-center text-gray-500 mt-10"
                >
                  {showPassword ? (
                    <EyeOff size={20} aria-hidden="true" />
                  ) : (
                    <Eye size={20} aria-hidden="true" />
                  )}
                </button>
              )}
            </div>
            {errors.password && (
              <p className="text-red-500 text-sm mt-1">{errors.password}</p>
            )}
            <div className="mt-4">
              <div className="flex justify-between">
                <label className="text-[20px] block text-white-700 font-bold mb-2">
                  Confirm password
                </label>
              </div>
              <input
                className="bg-white-200 text-black focus:outline-none focus:shadow-outline border border-white-300 rounded py-2 px-4 block w-full appearance-none"
                type="password"
              />
            </div>
            <div className="mt-8">
              <button
                type="submit"
                className=" rounded text-[20px] bg-[#5D462D] text-white font-bold py-2 px-10 w-full shadow-2xl"
              >
                Register
              </button>
            </div>
          </form>
          <div
            className="hidden lg:block lg:w-1/2 bg-cover"
            style={{
              backgroundImage: "url('/assets/images/login/login.jpg')",
            }}
          ></div>
        </div>
      </div>
    );

}

export default SignUp;