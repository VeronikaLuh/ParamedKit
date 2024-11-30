"use client";

import { imageUrl } from "@/utils/constants";
import InfoItem from "@/components/InfoItem";
import React, { useState } from "react";
import { useSwipeable } from "react-swipeable";
import { useRouter } from "next/navigation";
import Carousel from "../components/homepage/Caurosel";
import { Routes } from "@/types/routes";
import "@splidejs/splide/css";
// @ts-ignore
import { Splide, SplideSlide } from "@splidejs/react-splide";

export default function Home() {
  const data = [
    {
      title: "Register or login",
      description:
        "Quick way to choose where you must go today. Delicious and beautiful places await you",
      enableButton: true,
      buttonText: "Register",
      url: Routes.SIGN_UP,
    },
    {
      title: "Choose preferences",
      description:
        "Quick way to choose where you must go today. Delicious and beautiful places await you",
      enableButton: true,
      buttonText: "Make choice",
      url: Routes.PREFERENCES,
    },
    {
      title: "Like or pass",
      description:
        "Quick way to choose where you must go today. Delicious and beautiful places await you",
      enableButton: true,
      buttonText: "Let's match",
      url: Routes.MATCH,
    },
    {
      title: "Don`t like swipe?",
      description:
        "Quick way to choose where you must go today. Delicious and beautiful places await you",
      enableButton: true,
      buttonText: "Search",
      url: Routes.SEARCH,
    },
  ];

  const [currentIndex, setCurrentIndex] = useState(0);

  const handlePrev = () => {
    setCurrentIndex((prevIndex) =>
      prevIndex === 0 ? data.length - 1 : prevIndex - 1
    );
  };

  const handleNext = () => {
    setCurrentIndex((prevIndex) =>
      prevIndex === data.length - 1 ? 0 : prevIndex + 1
    );
  };

  const swipeHandlers = useSwipeable({
    onSwipedLeft: handleNext,
    onSwipedRight: handlePrev,
    preventScrollOnSwipe: true,
    trackMouse: true,
  });

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
              Lorem ipsum dolor sit amet, consectetur adipisicing elit. Hic,
              itaque saepe? Ab aliquam dicta, dolores ea enim eveniet,
              exercitationem facilis fugiat impedit iusto nesciunt quibusdam
              quis rem sint ut vel. Alias asperiores assumenda aut blanditiis
              consequatur consequuntur distinctio doloribus harum ipsa maxime,
              porro quidem ratione repudiandae ullam ut, vero, vitae? Animi
            </p>
            <button className="mt-[41px] bg-[#5D462D] py-2 px-9 rounded-[40px] font-bold text-[1.5rem] w-left md:w-fit text-[2rem]">
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
