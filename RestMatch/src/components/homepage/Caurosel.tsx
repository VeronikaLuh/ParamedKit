import InfoItem from "@/components/InfoItem";
import { Routes } from "@/types/routes";
import { useRouter } from "next/navigation";
import React, { useState, useEffect } from "react";

interface CarouselItem {
  title: string;
  description: string;
  buttonText?: string;
  url: Routes;
}

interface CarouselProps {
  data: CarouselItem[];
  autoSlide?: boolean;
  autoSlideInterval?: number;
}

const Carousel: React.FC<CarouselProps> = ({
  data,
  autoSlide = true,
  autoSlideInterval = 20000,
}) => {
  const [currentIndex, setCurrentIndex] = useState(0);

  useEffect(() => {
    if (autoSlide) {
      const slideInterval = setInterval(() => {
        setCurrentIndex((prevIndex) => (prevIndex + 1) % data.length);
      }, autoSlideInterval);
      return () => clearInterval(slideInterval);
    }
  }, [autoSlide, autoSlideInterval, data.length]);

  const nextSlide = () => {
    setCurrentIndex((prevIndex) => (prevIndex + 1) % data.length);
  };

  const getSlideIndex = (index: number): number => {
    return (index + data.length) % data.length;
  };

  const isVisible = (index: number): boolean => {
    const relativeIndex = (index - currentIndex + data.length) % data.length;
    return relativeIndex === 0 || relativeIndex === 1 || relativeIndex === data.length - 1;
  };

  const prevSlide = () => {
    setCurrentIndex((prevIndex) => (prevIndex - 1 + data.length) % data.length);
  };

  const router = useRouter();
  const handleRoute = (url: Routes) => {
    router.push(url);
  };


  return (
    <div className="relative w-full max-w-3xl mx-auto overflow-hidden pt-6">
      <div className="flex items-center justify-center relative h-80">
        {data.map((item, index) => {
          const relativeIndex = (index - currentIndex + data.length) % data.length;

          // Визначення позиції
          const isCenter = relativeIndex === 0;
          const isLeft = relativeIndex === data.length - 1;
          const isRight = relativeIndex === 1; ;

          if (!isVisible(index)) {
            return null;
          }

          let transformClass = "";
          if (isCenter) transformClass = "translate-x-full scale-100 z-20";
          else if (isLeft) transformClass = "ml-[-70.666667%] scale-90 z-10";
          else if (isRight) transformClass = "ml-[70.666667%] scale-90 z-10";

          return (
            <div
              key={index}
              className={`absolute top-0 left-1/2 transform -translate-x-1/2 transition-transform duration-700 ease-in-out ${transformClass}`}
              style={{ width: isCenter ? "80%" : "60%", height: "100%" }}
            >
              <div className="shadow-lg rounded-lg overflow-hidden bg-white">
                <InfoItem
                  title={item.title}
                  description={item.description}
                  buttonText={item.buttonText}
                  onClickHandle={() => handleRoute(item.url)}
                />
              </div>
            </div>
          );
        })}
      </div>
      <button
        className="absolute top-1/2 left-0 transform -translate-y-1/2 bg-gray-800 text-white p-2"
        onClick={prevSlide}
      >
        Prev
      </button>
      <button
        className="absolute top-1/2 right-0 transform -translate-y-1/2 bg-gray-800 text-white p-2"
        onClick={nextSlide}
      >
        Next
      </button>
      <div className="relative bottom-0 left-0 right-0 flex justify-center mt-4">
        {data.map((_, index) => (
          <div
            key={index}
            className={`w-3 h-3 rounded-full mx-1 ${
              index === currentIndex ? "bg-white" : "bg-gray-400"
            }`}
            onClick={() => setCurrentIndex(index)}
          />
        ))}
      </div>
    </div>
  );
};

export default Carousel;
