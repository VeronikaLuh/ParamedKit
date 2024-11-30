"use client";

import { imageUrl } from "@/utils/constants";
import InfoItem from "@/components/InfoItem";
import React from "react";
import { useRouter } from "next/navigation";
import { Routes } from "@/types/routes";
import "@splidejs/splide/css";
// @ts-ignore
import { Splide, SplideSlide } from "@splidejs/react-splide";

export default function Home() {
  const data = [
    {
      title: "Register or login",
      description:
        "Sign up or log in to personalize your experience and start discovering the best restaurants tailored to your tastes!",
      enableButton: true,
      buttonText: "Register",
      url: Routes.SIGN_UP,
    },
    {
      title: "Set preferences",
      description:
        "Set your preferences easily with our interactive selection to get restaurant recommendations that match your style!",
      enableButton: true,
      buttonText: "Make choice",
      url: Routes.PREFERENCES,
    },
    {
      title: "Like or pass",
      description:
        "Use our fun and interactive swipe feature to quickly choose your next dining spot based on smart recommendations!",
      enableButton: true,
      buttonText: "Let's match",
      url: Routes.MATCH,
    },
    {
      title: "Don`t like swipe?",
      description:
        "Find your perfect restaurant by filtering results based on your specific needs and desires!",
      enableButton: true,
      buttonText: "Search",
      url: Routes.SEARCH,
    },
  ];

  const router = useRouter();
  const handleRoute = (url: Routes) => {
    router.push(url);
  };

  return (
    <main>
      <div className="flex px-6 h-[460px] md:h-[582.5px]">
        <img
          className="hidden md:block absolute w-full top-0 left-0 right-0 h-[582px]"
          src={`${imageUrl}/homepage/home-background.png`}
          alt="coffee"
        />
        <img
          className="absolute w-full top-0 left-0 right-0 h-[520px] rounded-b-[50px] md:hidden "
          src={`${imageUrl}/homepage/main_sm3.jpg`}
          alt="coffee"
        />
        <div className="z-10 mt-7 flex justify-between w-full font-medium md:mt-[80px]">
          <h2 className="hidden md:block max-w-[521px] text-left">
            Find the best place to hangout with friends or celebrate important
            event
          </h2>
          <h2 className="hidden md:block max-w-[500px] text-right">
            Quick way to choose where you must go today. Delicious and beautiful
            places await you
          </h2>
          <h2 className="max-w-[180px] md:hidden">
            Quick way to choose where you must go today. Delicious and beautiful
            places await you
          </h2>
        </div>
      </div>
      <div className="sm: pt-[20px] px-6 lg:px-6">
        <h2 className="font-bold">What you need?</h2>
        <hr />
        <div className="hidden md:grid gap-2 mt-6 grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
          {data.map((item, index) => (
            <InfoItem
              key={index}
              title={item.title}
              description={item.description}
              buttonText={item.buttonText}
              onClickHandle={() => handleRoute(item.url)}
            />
          ))}
        </div>
      </div>
      <div className="pt-6 md:hidden md:pt-0">
        <Splide
          options={{
            rewind: true,
            gap: "1rem",
            type: "loop",
            padding: "2.3rem",
            drag: "free",
            snap: true,
          }}
          aria-label="Dynamic Items Slider"
        >
          {data.map((item, index) => (
            <SplideSlide key={index}>
              <InfoItem
                title={item.title}
                description={item.description}
                buttonText={item.buttonText}
                onClickHandle={() => handleRoute(item.url)}
              />
            </SplideSlide>
          ))}
        </Splide>
      </div>
      <div className="pt-[80px] pb-[44px] pl-6 pr-6 lg:pr-0">
        <div className="flex relative">
          <div className="flex-[3]">
            <h2 className="font-bold mb-[19px]">
              Want to see place that you liked earlier?
            </h2>
            <p className="leading-9 text-[1.6rem] md:text-[1.875rem]">
              Found a restaurant you love? Save it to your &#34;My Saved Places&#34; tab
              with just a tap! This way, you can easily revisit your favorite
              spots or explore them later at your convenience. Never worry about
              forgetting the name of that perfect place again!
            </p>

            <button
              onClick={() => handleRoute(Routes.SAVED_PLACES)}
              className="mt-[41px] bg-[#5D462D] py-2 px-9 rounded-[40px] font-bold w-left md:w-fit text-[2rem]">
              My saved
            </button>
          </div>
          <div className="xl:flex-[1] hidden lg:flex justify-end ">
            <img
              src={`${imageUrl}/homepage/coffee-hand.png`}
              className="h-[280px] w-[315px] xl:h-fit xl:w-auto"
              alt="hand with coffe"
            />
          </div>
        </div>
      </div>
    </main>
  );
}
